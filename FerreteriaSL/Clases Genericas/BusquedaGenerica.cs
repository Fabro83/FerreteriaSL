using System;
using System.ComponentModel;
using System.Data;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Clases_Genericas
{
    public delegate void SearchEndedHandler(DataTable result);
    public delegate void SearchInProgressHandler();

    class BusquedaGenerica
    {
        Bd _dbCon;
        DataTable _lastSearchResult;
        string _lastQuery;

        BackgroundWorker _bgwSearch;
        bool _isSearchInProgress;
        int _itemsPerPage;
        int _searchTotalItemCount;
        int _currentPage;
        int _totalPages;
        string _newSearch;
        DateTime _sleepTimer;

        int _lastSelectedRowIndex, _lastSelectedColumnIndex;

        public int LastSelectedColumnIndex
        {
            get { return _lastSelectedColumnIndex; }
            set { _lastSelectedColumnIndex = value; }
        }

        public int LastSelectedRowIndex
        {
            get { return _lastSelectedRowIndex; }
            set { _lastSelectedRowIndex = value; }
        }

        public int TotalPages
        {
            get { return _totalPages; }
            set { _totalPages = value; }
        }
        public int CurrentPage
        {
            get { return _currentPage; }
            set 
            {
                int newPage = value;
                if (newPage >= 0 && (newPage < _totalPages))
                {
                    //afldbg.log(this, "currentPage Value Change");
                    _currentPage = value;
                    StartSearch(_lastQuery);
                }
                    
            }
        }
        public event SearchEndedHandler SearchEnded;
        public event SearchInProgressHandler SearchInProgress;
        public int SearchTotalItemCount
        {
            get { return _searchTotalItemCount; }
        }
        public int ItemsPerPage
        {
          get { return _itemsPerPage; }
            set { _itemsPerPage = value;  StartSearch(_lastQuery); }
        }
        public bool IsSearchInProgress
        {
            get { return _isSearchInProgress; }
        }

        public BusquedaGenerica()
        {
            _dbCon = new Bd();
            _lastSearchResult = null;
            _isSearchInProgress = false;
            _bgwSearch = new BackgroundWorker();
            _itemsPerPage = 10;
            
            _bgwSearch.DoWork += bgw_search_DoWork;
            _bgwSearch.WorkerSupportsCancellation = true;
            _bgwSearch.RunWorkerCompleted += bgw_search_RunWorkerCompleted;
            _bgwSearch.WorkerReportsProgress = true;
            _bgwSearch.ProgressChanged += bgw_search_ProgressChanged;
        }

               void bgw_search_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            OnSearchInProgress();
        }

        void OnSearchInProgress()
        {
            if (SearchInProgress != null)
                SearchInProgress();
        }

        void OnSearchEnded(DataTable result)
        {
            if (SearchEnded != null)
                SearchEnded(result);
        }

        public void StartSearch(string query)
        {
            ////afldbg.log(this,"StartSearch()");
            ////afldbg.log(this, "query = " + query,"blue");
            if (query == null)
                return;

            if (query != _lastQuery)
                _currentPage = 0;

            if (_bgwSearch.IsBusy)
            {
                _newSearch = query;
            }
            else
            {
                _isSearchInProgress = true;
                OnSearchInProgress();
                _bgwSearch.RunWorkerAsync(query);
            }
        }

        void bgw_search_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _isSearchInProgress = false;
            //afldbg.log(this, "bgw_search_RunWorkerCompleted()");
            if (_newSearch != String.Empty)
            {
                //afldbg.log(this, "bgw_search_RunWorkerCompleted > IF");
                //afldbg.log(this, "newSearch = "+newSearch,"blue");
                string ns = _newSearch;
                _newSearch = String.Empty;
                StartSearch(ns);
            }
            else
            {
                //afldbg.log(this, "bgw_search_RunWorkerCompleted > ELSE");
                _lastSearchResult = e.Result as DataTable;                
                OnSearchEnded(_lastSearchResult);
            }
        }

        void bgw_search_DoWork(object sender, DoWorkEventArgs e)
        {
            //afldbg.log(this, "bgw_search_DoWork()");
            //afldbg.log(this, "query = " + e.Argument.ToString(), "blue");
            if (_bgwSearch.CancellationPending)
            {
                //afldbg.log(this, "bgw_search_DoWork > IF");
                e.Cancel = true;
                return;
            }
            else
            {
                //afldbg.log(this, "bgw_search_DoWork > ELSE");
                string query = e.Argument as string;             
                _totalPages = GetPageCount(query);
                DataTable result = _dbCon.Read(ApplyLimitToQuery(query));
                e.Result = result;
                _lastQuery = e.Argument as string;
            }
        }

        private int GetPageCount(string query)
        {
            Bd dbCon = new Bd();
            double items = double.Parse(dbCon.Read(query.Replace("*", "Count(*)")).Rows[0][0].ToString());
            _searchTotalItemCount = Convert.ToInt32(items);
            if (_itemsPerPage == -1)
            {
                return 1;
            }
            else
            {
                int pages = Convert.ToInt32(Math.Ceiling(items / Convert.ToDouble(_itemsPerPage)));
                return pages;
            }
        }

        string ApplyLimitToQuery(string query)
        {
            if (_itemsPerPage != -1)
            {
                return query + " LIMIT " + _currentPage * _itemsPerPage + "," + _itemsPerPage;
            }
            else
            {
                return query;
            }

        }

        public void CancelSearch()
        {
            //afldbg.log(this, "CancelSearch()","red");              
            _bgwSearch.CancelAsync();
        }

    }
}

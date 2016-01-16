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
        readonly Bd _dbCon;
        DataTable _lastSearchResult;
        string _lastQuery;

        readonly BackgroundWorker _bgwSearch;
        int _itemsPerPage;
        int _currentPage;
        string _newSearch;
        DateTime _sleepTimer;

        public int LastSelectedColumnIndex { get; set; }

        public int LastSelectedRowIndex { get; set; }

        public int TotalPages { get; set; }

        public int CurrentPage
        {
            get { return _currentPage; }
            set 
            {
                int newPage = value;
                if (newPage >= 0 && (newPage < TotalPages))
                {
                    //afldbg.log(this, "currentPage Value Change");
                    _currentPage = value;
                    StartSearch(_lastQuery);
                }
                    
            }
        }
        public event SearchEndedHandler SearchEnded;
        public event SearchInProgressHandler SearchInProgress;
        public int SearchTotalItemCount { get; private set; }

        public int ItemsPerPage
        {
          get { return _itemsPerPage; }
            set { _itemsPerPage = value;  StartSearch(_lastQuery); }
        }
        public bool IsSearchInProgress { get; private set; }

        public BusquedaGenerica()
        {
            LastSelectedRowIndex = 0;
            LastSelectedColumnIndex = 0;
            _dbCon = new Bd();
            _lastSearchResult = null;
            IsSearchInProgress = false;
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
                IsSearchInProgress = true;
                OnSearchInProgress();
                _bgwSearch.RunWorkerAsync(query);
            }
        }

        void bgw_search_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IsSearchInProgress = false;
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
            }
            else
            {
                //afldbg.log(this, "bgw_search_DoWork > ELSE");
                string query = e.Argument as string;             
                TotalPages = GetPageCount(query);
                DataTable result = _dbCon.Read(ApplyLimitToQuery(query));
                e.Result = result;
                _lastQuery = e.Argument as string;
            }
        }

        private int GetPageCount(string query)
        {
            Bd dbCon = new Bd();
            double items = double.Parse(dbCon.Read(query.Replace("*", "Count(*)")).Rows[0][0].ToString());
            SearchTotalItemCount = Convert.ToInt32(items);
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

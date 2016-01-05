using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;

namespace FerreteriaSL
{
    public delegate void SearchEndedHandler(DataTable Result);
    public delegate void SearchInProgressHandler();

    class BusquedaGenerica
    {
        BD DBCon;
        DataTable lastSearchResult;
        string lastQuery;

        BackgroundWorker bgw_search;
        bool isSearchInProgress;
        int itemsPerPage;
        int searchTotalItemCount;
        int currentPage;
        int totalPages;
        string newSearch;
        DateTime sleepTimer;

        int lastSelectedRowIndex = 0, lastSelectedColumnIndex = 0;

        public int LastSelectedColumnIndex
        {
            get { return lastSelectedColumnIndex; }
            set { lastSelectedColumnIndex = value; }
        }

        public int LastSelectedRowIndex
        {
            get { return lastSelectedRowIndex; }
            set { lastSelectedRowIndex = value; }
        }

        public int TotalPages
        {
            get { return totalPages; }
            set { totalPages = value; }
        }
        public int CurrentPage
        {
            get { return currentPage; }
            set 
            {
                int newPage = value;
                if (newPage >= 0 && (newPage < totalPages))
                {
                    //afldbg.log(this, "currentPage Value Change");
                    currentPage = value;
                    StartSearch(lastQuery);
                }
                    
            }
        }
        public event SearchEndedHandler SearchEnded;
        public event SearchInProgressHandler SearchInProgress;
        public int SearchTotalItemCount
        {
            get { return searchTotalItemCount; }
        }
        public int ItemsPerPage
        {
          get { return itemsPerPage; }
            set { itemsPerPage = value;  StartSearch(lastQuery); }
        }
        public bool IsSearchInProgress
        {
            get { return isSearchInProgress; }
        }

        public BusquedaGenerica()
        {
            DBCon = new BD();
            lastSearchResult = null;
            isSearchInProgress = false;
            bgw_search = new BackgroundWorker();
            itemsPerPage = 10;
            
            bgw_search.DoWork += new DoWorkEventHandler(bgw_search_DoWork);
            bgw_search.WorkerSupportsCancellation = true;
            bgw_search.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_search_RunWorkerCompleted);
            bgw_search.WorkerReportsProgress = true;
            bgw_search.ProgressChanged += new ProgressChangedEventHandler(bgw_search_ProgressChanged);
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

        void OnSearchEnded(DataTable Result)
        {
            if (SearchEnded != null)
                SearchEnded(Result);
        }

        public void StartSearch(string query)
        {
            ////afldbg.log(this,"StartSearch()");
            ////afldbg.log(this, "query = " + query,"blue");
            if (query == null)
                return;

            if (query != lastQuery)
                currentPage = 0;

            if (bgw_search.IsBusy)
            {
                newSearch = query;
            }
            else
            {
                isSearchInProgress = true;
                OnSearchInProgress();
                bgw_search.RunWorkerAsync(query);
            }
        }

        void bgw_search_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isSearchInProgress = false;
            //afldbg.log(this, "bgw_search_RunWorkerCompleted()");
            if (newSearch != String.Empty)
            {
                //afldbg.log(this, "bgw_search_RunWorkerCompleted > IF");
                //afldbg.log(this, "newSearch = "+newSearch,"blue");
                string ns = newSearch;
                newSearch = String.Empty;
                StartSearch(ns);
            }
            else
            {
                //afldbg.log(this, "bgw_search_RunWorkerCompleted > ELSE");
                lastSearchResult = e.Result as DataTable;                
                OnSearchEnded(lastSearchResult);
            }
        }

        void bgw_search_DoWork(object sender, DoWorkEventArgs e)
        {
            //afldbg.log(this, "bgw_search_DoWork()");
            //afldbg.log(this, "query = " + e.Argument.ToString(), "blue");
            if (bgw_search.CancellationPending)
            {
                //afldbg.log(this, "bgw_search_DoWork > IF");
                e.Cancel = true;
                return;
            }
            else
            {
                //afldbg.log(this, "bgw_search_DoWork > ELSE");
                string query = e.Argument as string;             
                totalPages = getPageCount(query);
                DataTable Result = DBCon.Read(applyLimitToQuery(query));
                e.Result = Result;
                lastQuery = e.Argument as string;
            }
        }

        private int getPageCount(string query)
        {
            BD DBCon = new BD();
            double items = double.Parse(DBCon.Read(query.Replace("*", "Count(*)")).Rows[0][0].ToString());
            searchTotalItemCount = Convert.ToInt32(items);
            if (itemsPerPage == -1)
            {
                return 1;
            }
            else
            {
                int pages = Convert.ToInt32(Math.Ceiling(items / Convert.ToDouble(itemsPerPage)));
                return pages;
            }
        }

        string applyLimitToQuery(string query)
        {
            if (itemsPerPage != -1)
            {
                return query + " LIMIT " + currentPage * itemsPerPage + "," + itemsPerPage;
            }
            else
            {
                return query;
            }

        }

        public void CancelSearch()
        {
            //afldbg.log(this, "CancelSearch()","red");              
            bgw_search.CancelAsync();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.Class
{
    class Book
    {
        public Book()
        { }

        public Book(string _bookid, string _bookname, string _bookauthor, DateTime? _bookpublishtime, string _bookpublisher, decimal? _bookprice, string _bookcategory, string _bookdescription, bool _bookresources, string _bookimage)
        {
            this.BookID = _bookid;
            this.BookName = _bookname;
            this.BookAuthor = _bookauthor;
            this.BookPublishTime = _bookpublishtime;
            this.BookPublisher = _bookpublisher;
            this.BookPrice = _bookprice;
            this.BookCategory = _bookcategory;
            this.BookDescription = _bookdescription;
            this.BookResources = _bookresources;
            this.BookImage = _bookimage;
        }

        #region Model
        private string _bookid;
        private string _bookname;
        private string _bookauthor;
        private DateTime? _bookpublishtime;
        private string _bookpublisher;
        private decimal? _bookprice;
        private string _bookcategory;
        private string _bookdescription;
        private bool _bookresources;
        private string _bookimage;
        /// <summary>
        /// 
        /// </summary>
        public string BookID
        {
            set { _bookid = value; }
            get { return _bookid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BookName
        {
            set { _bookname = value; }
            get { return _bookname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BookAuthor
        {
            set { _bookauthor = value; }
            get { return _bookauthor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? BookPublishTime
        {
            set { _bookpublishtime = value; }
            get { return _bookpublishtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BookPublisher
        {
            set { _bookpublisher = value; }
            get { return _bookpublisher; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? BookPrice
        {
            set { _bookprice = value; }
            get { return _bookprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BookCategory
        {
            set { _bookcategory = value; }
            get { return _bookcategory; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BookDescription
        {
            set { _bookdescription = value; }
            get { return _bookdescription; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool BookResources
        {
            set { _bookresources = value; }
            get { return _bookresources; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BookImage
        {
            set { _bookimage = value; }
            get { return _bookimage; }
        }
        #endregion Model

    }
}

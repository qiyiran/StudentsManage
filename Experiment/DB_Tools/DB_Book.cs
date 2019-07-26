using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experiment.Class;

namespace Experiment.DB_Tools
{
    class DB_Book
    {
        public static DataTable GetBookInfoByID(string bookID)
        {
            string sql = "select * from Book where BookID = '" + bookID + "'";
            return DBAccess.ExecuteQueryReturnDT(sql);
        }

        public static int AddBookInfo(Book book)
        {
            string sql = "insert into Book values ('" + book.BookID + "','" + book.BookName + "','" + book.BookAuthor + "','" + book.BookPublishTime + "','" + book.BookPublisher
                + "','" + book.BookPrice + "','" + book.BookCategory + "','" + book.BookDescription + "','" + book.BookResources + "','" + book.BookImage + "')";
            return DBAccess.ExecuteNonQuery(sql);
        }

        public static int UpdateBookInfo(Book book)
        {
            string sql = "update Book set BookName='" + book.BookName + "',BookAuthor='" + book.BookAuthor + "',BookPublishTime='" + book.BookPublishTime + "',BookPublisher='" + book.BookPublisher
                + "',BookPrice='" + book.BookPrice + "',BookCategory='" + book.BookCategory + "',BookDescription='" + book.BookDescription + "',BookResources='"
                + book.BookResources + "',BookImage='" + book.BookImage + "' where BookID = '" + book.BookID + "'";
            return DBAccess.ExecuteNonQuery(sql);
        }

        public static int DelBookInfo(string bookid)
        {
            string sql = "delete from Book where BookID = '" + bookid + "'";
            return DBAccess.ExecuteNonQuery(sql);
        }
    }
}

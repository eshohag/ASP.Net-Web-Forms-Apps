using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using BookInfoApp.DAL.Model;

namespace BookInfoApp.DAL.Gateway
{
    public class BookGatway : CommonGateway
    {
       
        public int Save(Book aBook)
        {
            Query = "INSERT INTO Book (Name, ISBN, Author) VALUES('" + aBook.Name + "', '" + aBook.ISBN + "', '" + aBook.Author + "')";
            Command = new SqlCommand(Query, Connection);          
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public Book IsISBNNoExist(string isbn)
        {       
            Query = "SELECT * FROM Book WHERE ISBN='" + isbn + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Book aBook = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aBook = new Book();
                aBook.Id = Convert.ToInt32(Reader["Id"]);
                aBook.ISBN = Reader["ISBN"].ToString();
                aBook.Name = Reader["Name"].ToString();
                aBook.Author = Reader["Author"].ToString();
              
            }

            Reader.Close();
            Connection.Close();
            return aBook;
        }
        
        public List<Book> GetAllBooks()
        {          
            Query = "SELECT * FROM Book";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Book> Books = new List<Book>();
            while (Reader.Read())
            {
                Book Book = new Book();
                Book.Id = Convert.ToInt32(Reader["Id"]);               
                Book.Name = Reader["Name"].ToString();
                Book.ISBN = Reader["ISBN"].ToString();
                Book.Author = Reader["Author"].ToString();
                Books.Add(Book);
            }
            Reader.Close();
            Connection.Close();
            return Books;
        }

        public List<Book> SearchByName(string name)
        {
            Query = "SELECT * FROM Book WHERE Name LIKE '%" +name+ "%' OR Author LIKE '%" +name+ "%'" ;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Book Book = null;
            List<Book> Books = new List<Book>();
            while (Reader.Read())
            {
                Book = new Book();
                Book.Id = Convert.ToInt32(Reader["Id"]);
                Book.Name = Reader["Name"].ToString();
                Book.ISBN = Reader["ISBN"].ToString();
                Book.Author = Reader["Author"].ToString();
                Books.Add(Book);
            }
            Reader.Close();
            Connection.Close();
            return Books;
        } 
    }
}
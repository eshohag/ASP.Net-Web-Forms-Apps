using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInfoApp.DAL.Gateway;
using BookInfoApp.DAL.Model;

namespace BookInfoApp.BLL
{
    public class BookManager
    {
        BookGatway aBookGatway=new BookGatway();

        public string Save(Book aBook)
        {
            if (aBookGatway.IsISBNNoExist(aBook.ISBN) == null)
            {
                if ((aBook.Name.Length != 0) && (aBook.Author.Length != 0))
                {
                    if (aBook.ISBN.Length == 13)
                    {
                        if (aBookGatway.Save(aBook) > 0)
                        {
                            return "Save Successfully";
                        }
                        else
                        {
                            return "Save Faild";
                        }
                    }
                    else
                    {
                        return "ISBN Key Must Be 13 Charecter";
                    }
                }
                else
                {
                    return "Please Fill in the Blank";
                }           
            }
            else
            {
                return "Already Entered Your ISBN Key";                           
            }                
        }
        
        public List<Book> GetAllBooks()
        {
            return aBookGatway.GetAllBooks();
        }

        public List<Book> SearchByName(string name)
        {
            return aBookGatway.SearchByName(name);
        }
    }
}
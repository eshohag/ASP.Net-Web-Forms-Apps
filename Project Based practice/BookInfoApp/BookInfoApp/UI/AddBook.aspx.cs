using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInfoApp.BLL;
using BookInfoApp.DAL.Model;

namespace BookInfoApp.UI
{
    public partial class AddBook : System.Web.UI.Page
    {
        BookManager aManager=new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Book aBook = new Book();
            aBook.Name = nameTextBox.Text;
            aBook.ISBN = isbnTextBox.Text;
            aBook.Author = authorTextBox.Text;

            string message = aManager.Save(aBook);
           
            messageLabel.Text = message;

            //nameTextBox.Text = String.Empty;
            //isbnTextBox.Text = String.Empty;
            //authorTextBox.Text = String.Empty;
        }

        protected void indexBookButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("IndexUI.aspx");
        }

        protected void showAllBookButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowBook.aspx");
        }
    }
}
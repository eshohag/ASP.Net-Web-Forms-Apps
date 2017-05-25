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
    public partial class ShowBook : System.Web.UI.Page
    {
        BookManager aManager=new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowGridView();
        }

        private void ShowGridView()
        {
            showGridView.DataSource = aManager.GetAllBooks();
            showGridView.DataBind();
        }


        protected void searchButton_Click(object sender, EventArgs e)
        {
            string searchName = searchTextBox.Text;
            List<Book> aBooks = aManager.SearchByName(searchName);
            if (aBooks.Count==0)
            {
                showGridView.DataSource = null;
                showGridView.DataBind();
                messageLabel.Text = "Nothing to Save "+searchName;
            }
            else
            {
                showGridView.DataSource = aBooks;
                showGridView.DataBind();               
            }           
        }

        protected void againShowButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text=String.Empty;
            messageLabel.Text =String.Empty;
            ShowGridView();
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("IndexUI.aspx");
        }

        protected void addBookButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }
    }
}
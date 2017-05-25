using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FriendCircleInformation.BLL;
using FriendCircleInformation.DAL.Model;

namespace FriendCircleInformation.UI
{
    public partial class IndexUI : System.Web.UI.Page
    {
        CheckPersonDetails aCheckPersonDetails=new CheckPersonDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            GetPersonList();
        }

        private void GetPersonList()
        {
            showGridView.DataSource = aCheckPersonDetails.GetPersonList();
            showGridView.DataBind();
        }
        public void CleanTextBox()
        {
            nameTextBo1.Text=String.Empty;
            bloodGroupTextBox.Text=String.Empty;
            emailTextBox.Text=String.Empty;
            mobileNumberTextBox.Text=String.Empty;
            locationTextBox.Text=String.Empty;
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Person aPerson=new Person();
            aPerson.Name = nameTextBo1.Text;
            aPerson.BloodGroup = bloodGroupTextBox.Text;
            aPerson.Email = emailTextBox.Text;
            aPerson.MobileNo = mobileNumberTextBox.Text;
            aPerson.Location = locationTextBox.Text;

            messageLabel.Text = aCheckPersonDetails.Save(aPerson);
            CleanTextBox();
            GetPersonList();
        }
    }
}
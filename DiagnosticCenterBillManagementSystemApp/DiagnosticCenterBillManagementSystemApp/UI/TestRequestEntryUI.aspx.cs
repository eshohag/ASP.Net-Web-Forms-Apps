using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenterBillManagementSystemApp
{
    public partial class TestRequestEntryUI : System.Web.UI.Page
    {
        Manager manager=new Manager();
        DataTable table;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadTestDropdownList();
                Session["Total"] = 0;
            }

            table = new DataTable();
            table.Columns.Add("Test", typeof(string));
            table.Columns.Add("Fee", typeof(string));
        }
        private void LoadTestDropdownList()
        {
            List<Tests> testList = manager.LoadTestDropdownList();

            selectTestDropDownList.DataTextField = "TestName";
            selectTestDropDownList.DataValueField = "Id";
            selectTestDropDownList.DataSource = testList;
            selectTestDropDownList.DataBind();
        }

        protected void addButtonTestReqEntryUI_Click(object sender, EventArgs e)
        {
            if (selectTestDropDownList.SelectedItem.Text != "" || feeTextBoxTestReqEntryUI.Text != "")
            {
                int previousTotal = (int) Session["Total"];
                int fee = Convert.ToInt32(feeTextBoxTestReqEntryUI.Text);
                int totalAmount = previousTotal + fee;
                totalAmountTextBox.Text = totalAmount.ToString();
                Session["Total"] = totalAmount;

                Session["Test"] += selectTestDropDownList.SelectedItem.Text + "|";
                string dueDate = DateTime.Now.Date.ToString();
                messageLabel.Text = manager.SaveTest(selectTestDropDownList.SelectedItem.Text, dueDate);
                Session["Fee"] += feeTextBoxTestReqEntryUI.Text + "|";
                CreateTable();
            }
        }

        public void CreateTable()
        {
            string[] sa = Session["Test"].ToString().Split('|');
            string[] sb = Session["Fee"].ToString().Split('|');

            int recordnum = sa.Length;

            for (int j = 0; j < recordnum - 1; j++)
            {

                DataRow dr = table.NewRow();
                dr["Test"] = sa[j].ToString();
                dr["Fee"] = sb[j].ToString();
                table.Rows.Add(dr);

            }

            testReqEntryGridView.DataSource = table.DefaultView;
            testReqEntryGridView.DataBind();
        }
        protected void selectTestDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FetchData(selectTestDropDownList.SelectedItem.Text);
        }
        private void FetchData(string selectedTest)
        {
            feeTextBoxTestReqEntryUI.Text = manager.FetchData(selectedTest);
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Patients aPatient = new Patients();
            aPatient.Name = patientNameTextBox.Text;
            aPatient.BirthDate = birthDateTextBox.Text;
            aPatient.Mobile = patientMobileTextBox.Text;
            Bills aBill=new Bills();
            aBill.TotalAmount = Convert.ToInt32(totalAmountTextBox.Text);
            aBill.DueDate = DateTime.Now.Date.ToString();
            aBill.BillNo = aPatient.Mobile + aPatient.Name;
            messageLabel.Text = manager.SavePatient(aPatient,aBill);
        }
    }
}
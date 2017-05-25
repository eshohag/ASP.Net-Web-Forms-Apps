using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenterBillManagementSystemApp
{
    public partial class TestWiseReportUI : System.Web.UI.Page
    {
        Manager manager=new Manager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButtonTestWiseReportUI_Click(object sender, EventArgs e)
        {
            string fromDate = fromDateTextBoxTestWiseReportUI.Text;
            string toDate = toDateTextBoxTestWiseReportUI.Text;

            List<TestList> testList = manager.TestExistByDate(fromDate, toDate);

            testWiseReportUIGridView.DataSource = testList;
            testWiseReportUIGridView.DataBind();

            totalTextBoxTestWiseReportUI.Text = testList.Select(n => n.TotalAmount).Sum().ToString();
        }
    }
}
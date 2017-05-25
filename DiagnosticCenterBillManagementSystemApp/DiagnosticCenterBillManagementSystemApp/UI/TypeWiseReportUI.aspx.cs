using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenterBillManagementSystemApp
{
    public partial class TypeWiseReportUI : System.Web.UI.Page
    {
        Manager manager=new Manager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButtonTypeWiseReportUI_Click(object sender, EventArgs e)
        {
            string fromDate = fromDateTextBoxTypeWiseReportUI.Text;
            string toDate = toDateTextBoxTypeWiseReportUI.Text;

            List<TestList> typeList = manager.TypeExistByDate(fromDate, toDate);
            typeWiseReportUIGridView.DataSource = typeList;
            typeWiseReportUIGridView.DataBind();

            totalTextBoxTypeWiseReportUI.Text = typeList.Select(n => n.TotalAmount).Sum().ToString();
        }
    }
}
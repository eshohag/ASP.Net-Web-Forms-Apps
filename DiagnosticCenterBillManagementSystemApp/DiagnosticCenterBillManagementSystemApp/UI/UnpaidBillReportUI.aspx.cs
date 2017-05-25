using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenterBillManagementSystemApp
{
    public partial class UnpaidBillReportUI : System.Web.UI.Page
    {
        Manager manager = new Manager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButtonUnpaidBillUI_Click(object sender, EventArgs e)
        {
            string fromDate = fromDateTextBoxUnpaidBillUI.Text;
            string toDate = toDateTextBoxUnpaidBillUI.Text;

            List<UnpaidPatientsView> unpaidPatientsView = manager.PatientExist(fromDate, toDate);
            unpaidBillReportGridView.DataSource = unpaidPatientsView;
            unpaidBillReportGridView.DataBind();

            float total = 0f;
            for (int i = 0; i < unpaidBillReportGridView.Rows.Count; i++)
            {
                Label individualBill = (Label)unpaidBillReportGridView.Rows[i].FindControl("totalAmountID");
                total += Convert.ToSingle(individualBill.Text);
                //GTotal += Convert.ToSingle(total);
            }
            totalTextBoxUnpaidBillUI.Text = total.ToString();
        }
    }
}
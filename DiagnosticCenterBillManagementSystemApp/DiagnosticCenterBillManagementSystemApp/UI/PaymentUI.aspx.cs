using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenterBillManagementSystemApp
{
    public partial class PaymentUI : System.Web.UI.Page
    {
        Manager manager=new Manager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButtonPaymentUI_Click(object sender, EventArgs e)
        {
            if (billNoTextBoxPaymentUI.Text != "")
            {
                string billNo = billNoTextBoxPaymentUI.Text;
                ViewState["BillNo"] = billNo;
                PaymentView paymentView = manager.GetPatientInfo(billNo);
                amountTextBoxPaymentUI.Text = paymentView.TotalAmount.ToString();
                dueDateTextBoxPaymentUI.Text = paymentView.DueDate;
                billNoTextBoxPaymentUI.Text = String.Empty;
                mobileNoTextBoxPaymentUI.Text = String.Empty;
            }
            else if (mobileNoTextBoxPaymentUI.Text != "")
            {
                string mobileNo = mobileNoTextBoxPaymentUI.Text;
                ViewState["MobileNo"] = mobileNo;
                PaymentView paymentView = manager.GetPatientInfo(mobileNo);
                amountTextBoxPaymentUI.Text = paymentView.TotalAmount.ToString();
                dueDateTextBoxPaymentUI.Text = paymentView.DueDate;
                billNoTextBoxPaymentUI.Text = String.Empty;
                mobileNoTextBoxPaymentUI.Text = String.Empty;

            }
            else
            {
                Response.Write("PLZ InPUT");
            }
        }

        protected void payButtonPaymentUI_Click(object sender, EventArgs e)
        {
            if (ViewState["BillNo"] != null)
            {
                string billNo = ViewState["BillNo"].ToString();
                messageLabel.Text = manager.DeletePatientByBillNo(billNo);
            }
            else if (ViewState["MobileNo"] != null)
            {
                string mobileNo = ViewState["MobileNo"].ToString();
                messageLabel.Text = manager.DeletePatientByMobileNo(mobileNo);
            }
            else
            {
                Response.Write("Plz enter Bill no or mobile no");
            }
        }
    }
}
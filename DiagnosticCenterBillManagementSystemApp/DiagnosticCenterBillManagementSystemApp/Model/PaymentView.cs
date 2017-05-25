using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagnosticCenterBillManagementSystemApp
{
    public class PaymentView
    {
        public int TotalAmount { get; set; }
        public string DueDate { get; set; }
        public string BillNo { get; set; }
        public string Mobile { get; set; }
    }
}
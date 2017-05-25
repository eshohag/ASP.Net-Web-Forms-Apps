using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagnosticCenterBillManagementSystemApp
{
    public class UnpaidPatientsView
    {
        public string BillNo { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public int TotalAmount { get; set; }
    }
}
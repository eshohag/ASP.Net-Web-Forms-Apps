using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagnosticCenterBillManagementSystemApp
{
    public class Bills
    {
        public int Id { get; set; }
        public string BillNo { get; set; }
        public string DueDate { get; set; }
        public int TotalAmount { get; set; }
        public int TestId { get; set; }

    }
}
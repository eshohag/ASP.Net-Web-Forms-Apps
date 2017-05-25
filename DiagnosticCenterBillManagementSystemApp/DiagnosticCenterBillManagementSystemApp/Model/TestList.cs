using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagnosticCenterBillManagementSystemApp
{
    public class TestList
    {
        public int Id { get; set; }
        public string DueDate { get; set; }
        public string TestName { get; set; }
        public string TypeName { get; set; }
        public int TotalNoOfTest { get; set; }
        public int TotalAmount { get; set; }
        public int SumOfTotalAmount { get; set; }
    }
}
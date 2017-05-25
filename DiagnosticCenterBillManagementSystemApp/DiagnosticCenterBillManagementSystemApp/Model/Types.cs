using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiagnosticCenterBillManagementSystemApp
{
    public class Types
    {
        public int Id { get; set; }
         [Required(ErrorMessage = "Name is required")]
        public string TypeName { get; set; }

    }
}
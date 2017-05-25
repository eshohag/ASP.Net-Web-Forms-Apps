using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStoreApp.DAL.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
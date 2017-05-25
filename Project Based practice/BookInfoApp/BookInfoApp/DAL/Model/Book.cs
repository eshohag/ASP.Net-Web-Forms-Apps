﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInfoApp.DAL.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
    }
}
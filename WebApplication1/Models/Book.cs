﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Book
    {
        // ID Ккниги
        public int ID { get; set; }

        // название книги
        public string Name { get; set; }

        // автор книги
        public string Author { get; set; }

        // цена
        public int Price { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmanahTask.Core.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

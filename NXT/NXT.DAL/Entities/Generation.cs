﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NXT.DAL.Entities
{
    public class Generation
    {
        public int Id { get; set; }
        public Region Region { get; set; } 
        public string Identifier {get;set;}
    }
}

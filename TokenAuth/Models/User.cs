﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuth.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simple_web_template.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password_Hash { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
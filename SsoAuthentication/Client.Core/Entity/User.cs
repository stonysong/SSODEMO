﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Core.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
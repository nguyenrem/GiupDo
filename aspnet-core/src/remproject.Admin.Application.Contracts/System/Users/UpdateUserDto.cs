﻿using System;
using System.Collections.Generic;
using System.Text;

namespace remproject.Admin.System.Users
{
    public class UpdateUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

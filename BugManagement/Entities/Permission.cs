﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }
    }
}
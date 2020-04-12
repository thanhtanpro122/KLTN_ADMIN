using System;
using System.Collections.Generic;
using System.Text;

namespace KLTN_Admin.Domain.ViewModels
{
    public class Admin
    {
        public long AdminID { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string Name { get; set; }

        public AdminStatus Status { get; set; }
    }

    public enum AdminStatus
    {
        SuperAdmin,
        Admin,
        Agent
    }
}

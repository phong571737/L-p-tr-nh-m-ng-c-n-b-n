using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class sqlite
    {
        public static string ConnectionString()
        {
            return "Data Source = MonAn.db;Version = 3";
        }
    }
}

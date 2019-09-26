using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularLibWebAPIApp.Utility
{
    public static class ConnectionString
    {
        //private static string cName = "Data Source=.; Initial Catalog=StudentManagement;User ID=sa;Password=123";
        private static string cName = "server=localhost\\SQLEXPRESS;Database=EmployeeData;Trusted_Connection=True;";
        public static string CName
        {
            get => cName;
        }
    }
}

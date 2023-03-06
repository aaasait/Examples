using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLStoreProcedure.DataBase
{
    internal class Database
    {

        public static string GetConnectingString
        {

           // "Server=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=AdventureWorks2019; Uid=sa; Password=AbdullahSaitKoc68";
           //  var str = "Server=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=NORTHWND; Uid=sa; Password=AbdullahSaitKoc68";

            get{
                return "Server=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=NORTHWND; Uid=sa; Password=AbdullahSaitKoc68";
            }
        }
    }
}

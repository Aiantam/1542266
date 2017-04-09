using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dts.Runtime;


namespace _1542266_CowImport
{
    class Program
    {
        static void Main(string[] args)
        {
            string pkgLocation = @"D:\1542266_GetName\1542266_GetName\Package.dtsx";

            Package pkg;
            Microsoft.SqlServer.Dts.Runtime.Application app;
            DTSExecResult pkgResults;
            Variables vars;

            app = new Microsoft.SqlServer.Dts.Runtime.Application();
            pkg = app.LoadPackage(pkgLocation, null);

            vars = pkg.Variables;
            vars["User::import_cow"].Value = @"C:\Users\ng.phuocloc\Downloads\chip2.txt";

            pkgResults = pkg.Execute(null, vars, null, null, null);

            if (pkgResults == DTSExecResult.Success)
                Console.WriteLine("Import successfully");
            else
                Console.WriteLine("Import failed");
        }
    }
}

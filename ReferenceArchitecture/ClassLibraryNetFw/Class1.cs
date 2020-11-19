using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNetFw
{
    public class Class1
    {
        public Class1()
        {
            var ds = new System.Security.AccessControl.DirectorySecurity();

            Directory.CreateDirectory(@"C:\temp\SA3\MyDir4", ds);
        }
    }
}

using System;
using System.IO;

namespace ClassLibraryNetStandard
{
    public class Class1
    {

        public Class1()
        {
            //Does not compile in .net Standard !

            //var ds = new System.Security.AccessControl.DirectorySecurity();

            //Directory.CreateDirectory(@"C:\temp\SA3\MyDir4", ds);
        }
    }
}

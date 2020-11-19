using System;

namespace ConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //dotnet publish -r linux-x64 -p:PublishSingleFile=true --self-contained true

            Console.WriteLine("Hello World!");
            Console.WriteLine(Environment.OSVersion.Platform);
            Console.WriteLine(Environment.OSVersion.Version);
            Console.WriteLine(Environment.OSVersion.VersionString);
        }
    }
}

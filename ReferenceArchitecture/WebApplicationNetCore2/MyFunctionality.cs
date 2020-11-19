using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplicationNetCore2
{
    public static class MyExtentions
    {
        public static void AddMyFunctionality(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<MyClass1>();
            serviceCollection.AddSingleton<MyClass2>();
        }
    }
    public class MyFunctionality
    {
    }

    public class MyClass1
    {

    }
    public class MyClass2
    {

    }
}

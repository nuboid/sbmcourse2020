using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBackendService001.Contracts;
using MyFramework;
using Refit;
using Xamarin.Forms;

namespace MyMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var proxy = RestService.For<IMyBackendService001Controller001>("");
            var a = proxy.GetSomeData(new SomeInputParameter());


            var logger = new MyLogger();
            logger.Log("jkhfkjsfd",LogLevel.Critical);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MediaServicesManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // modification: take out startup URI from Shell.xaml, and 
        // override OnStartup method

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Createa a bootstrapper application to start the application going

            PeopleManagerBootstrapper bootstrapper = new PeopleManagerBootstrapper();
            bootstrapper.Run();


        }
    }
}

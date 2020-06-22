using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Zajecia13
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var builder = new ContainerBuilder();
            builder.RegisterType<LabelGenerator>().As<IControlGenerator>(); //albo Rectangle
            builder.RegisterType<PanelFiller>().As<IPanelFiller>();
            builder.RegisterType<DbDataProvider>().As<IDataProvider>();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<Context>().AsSelf();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())                 
            {                                                                

                var window = scope.Resolve<MainWindow>();
                window.Show();
            };
        }
    }
}

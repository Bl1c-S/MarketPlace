using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Market_Place.HostBuilders;
using WPF_Market_Place.Services;
using WPF_Market_Place.Stores;
using WPF_Market_Place.ViewModel;
using WPF_Market_Place.ViewModel.SingInViewModel;

namespace WPF_Market_Place
{
     /// <summary>
     /// Interaction logic for App.xaml
     /// </summary>
     public partial class App : Application
     {
          private readonly IHost _host;
          public App()
          {
               _host = Host.CreateDefaultBuilder()
                .AddViewModels()
                .ConfigureServices((hostContext, services) =>
                {
                     services.AddSingleton<NavigationStore>();

                     services.AddSingleton(s => new MainWindow()
                     {
                          DataContext = s.GetRequiredService<MainViewModel>()
                     });
                })
                .Build();
          }

          protected override void OnStartup(StartupEventArgs e)
          {
               _host.Start();

               NavigationService<SingInViewModel> navigationService = _host.Services.GetRequiredService<NavigationService<SingInViewModel>>();
               navigationService.Navigate();

               MainWindow = _host.Services.GetRequiredService<MainWindow>();
               MainWindow.Show();

               MainWindow = new MainWindow()
               {
                    DataContext = new MainViewModel()
               };

               base.OnStartup(e);
          }

          protected override void OnExit(ExitEventArgs e)
          {
               _host.Dispose();

               base.OnExit(e);
          }
     }
}

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Market_Place.Services;
using WPF_Market_Place.ViewModel;
using WPF_Market_Place.ViewModel.SingInViewModel;

namespace WPF_Market_Place.HostBuilders
{
     public static class AddViewModelsHostBuilderExtensions
     {
          public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder)
          {
               hostBuilder.ConfigureServices(services =>
               {
                    services.AddSingleton<NavigationService<SingInViewModel>>();
                    services.AddSingleton<MainViewModel>();
               });

               return hostBuilder;
          }
     }
}

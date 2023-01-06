using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Market_Place.Stores;
using WPF_Market_Place.ViewModel;

namespace WPF_Market_Place.Services
{
     public class NavigationService<TViewModel> where TViewModel : ViewModelBase
     {
          private readonly NavigationStore _navigationStore;
          private readonly Func<TViewModel> _createViewModel;

          public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
          {
               _navigationStore = navigationStore;
               _createViewModel = createViewModel;
          }

          public void Navigate()
          {
               _navigationStore.CurrentViewModel = _createViewModel();
          }
     }
}

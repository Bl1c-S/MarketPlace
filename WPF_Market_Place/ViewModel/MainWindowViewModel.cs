using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Market_Place.Command;

namespace WPF_Market_Place.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
          public ICommand SingInCmd { get; }

          public MainViewModel()
          {
               SingInCmd = new SingInCommand();
          }
    }
}

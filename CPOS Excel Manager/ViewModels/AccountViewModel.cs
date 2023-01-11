using CPOS_Excel_Manager.Commands;
using CPOS_Excel_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CPOS_Excel_Manager.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public string Name => "SingletonSean";

        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}

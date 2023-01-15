using CPOS_Excel_Manager.Commands;
using CPOS_Excel_Manager.Models;
using CPOS_Excel_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CPOS_Excel_Manager.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
        }
    }
}

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
    public class PrintViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public PrintViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }

    }
}

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
        public ICommand NavigatePrintCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigatePrintCommand = new NavigateCommand<PrintViewModel>(navigationStore, () => new PrintViewModel(navigationStore));
        }
    }
}

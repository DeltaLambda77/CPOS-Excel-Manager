using CPOS_Excel_Manager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CPOS_Excel_Manager.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }
        

        public void SubtractTime()
        {
            DateTime today = DateTime.Now;
            TimeSpan singleDay = new TimeSpan(24, 0, 0);

            DateTime yesterday = today.Subtract(singleDay);

            Trace.WriteLine(yesterday);
            Trace.WriteLine(yesterday.ToString());

        }
        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            LoginCredentials.loginEmail = Email_TextBox.Text;
            LoginCredentials.loginPassword = Password_TextBox.Password;
            SubtractTime();
        }
    }
}

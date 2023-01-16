using System;
using CPOS_Excel_Manager.Services;
using System.Collections.Generic;
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
    /// Interaction logic for PrintView.xaml
    /// </summary>
    public partial class PrintView : UserControl
    {
        public PrintView()
        {
            InitializeComponent();
        }

        private void PrintCPOSButton_Click(object sender, RoutedEventArgs e)
        {
            Status_TextBox.Text = OutlookConnection.ConnectPop3Client();
            
        }
    }
}

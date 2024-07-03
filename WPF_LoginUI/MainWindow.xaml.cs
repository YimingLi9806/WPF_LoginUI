using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_LoginUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginModel loginModel;
        LoginViewModel loginViewModel;
        public MainWindow()
        {
            InitializeComponent();
            //loginModel = new LoginModel();
            //loginModel.UserName = "initial UN";
            //loginModel.PassWord = "initial PW";

            //this.DataContext = loginModel;

            loginViewModel = new LoginViewModel();
            this.DataContext = loginViewModel;
        }

       
        /*public string UserName { get; set; } = "333";
        public string PassWord { get; set; } = "123";*/
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (loginViewModel.LoginM.UserName == "333" && loginViewModel.LoginM.PassWord == "666")
            {
                Index index = new Index();
                index.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("no");
                loginViewModel.LoginM.PassWord = "No";
                loginViewModel.LoginM.UserName = "NO";
                loginViewModel.LoginM = loginViewModel.LoginM;
               
            }
            



        }
    }

    

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace WPF_LoginUI
{
    public class LoginViewModel:INotifyPropertyChanged
    {
            private MainWindow _mainWindow;
            public LoginViewModel(MainWindow main) 
            { 
                _mainWindow = main;
            }
            public event PropertyChangedEventHandler PropertyChanged;
            private void RaisePropertyChanged(string propertyName)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }

            }

       
      

        private LoginModel LoginM = new LoginModel();

        //private string _UserName;
        public string UserName
        {
            get { return LoginM.UserName; }
            set
            {
               
                LoginM.UserName = value;
                RaisePropertyChanged("UserName");
                
            }
        }

        public string PassWord
        {
            get { return LoginM.PassWord; }
            set
            {              
                 LoginM.PassWord = value;
                 RaisePropertyChanged("PassWord");              
            }
        }
       void LoginFunc()
       {

            if (UserName == "333" && PassWord == "666")
            {
                Index index = new Index();
                index.Show();
                _mainWindow.Hide();

            }
            else
            {
                MessageBox.Show("no");
                PassWord = "NO";
                UserName = "NO";


            }




       }
        //for binding the button
        bool CanLoginExecute() {  return true; }
        public ICommand LoginAction
        { 
            get 
            {
                return new RelayCommand(LoginFunc,CanLoginExecute);
            
            }        
        }

    }
}

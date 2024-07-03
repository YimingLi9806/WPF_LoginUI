using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginUI
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        
            public event PropertyChangedEventHandler PropertyChanged;
            private void RaisePropertyChanged(string propertyName)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }

            }

       
        

        private LoginModel _LoginM;
        public LoginModel LoginM
        {
            get { 

                if (_LoginM == null)
                    _LoginM = new LoginModel();
                return _LoginM; 
            }
            set
            {
                /*if (_LoginM != value)
                {*/
                    _LoginM = value;
                    RaisePropertyChanged("LoginM");
                
            }
        }

        //public LoginViewModel() { }
        
    }
}

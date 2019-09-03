using PoS.Dal.Mdl;
using Prism.Commands;

namespace PoS.ViewModels
{
    public class LoginCommandViewModel : ViewModelBase
    {
        private string _loginText;
        public string LoginText
        {
            get
            {
                return _loginText;
            }
            set
            {
                if (_loginText != value)
                {
                    _loginText = value;
                    NotifyPropertyChanged("LoginText");
                }
            }
        }

        public DelegateCommand LoginCommand
        {
            get;
            private set;
        }

        public LoginCommandViewModel()
        {
            LoginCommand = new DelegateCommand(ShowLoginFlyout);
        }

        private void ShowLoginFlyout()
        {
            User user = new User();
            if (IsLogin(out user) == false)
            {
                ShowFlyout("FlyoutLogin");
            }
            else
            {
                ShowFlyout("FlyoutUserInfo");
            }
        }
    }
}

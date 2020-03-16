using A1.Model;
using A1.View.Interfaces;
using System;
using System.Windows.Forms;

namespace A1.View.UC
{
    public partial class SignInControl : UserControl, ISignInControl
    {
        public SignInControl()
        {
            InitializeComponent();
        }

        public User User
        {
            get
            {
                return new User
                {
                    Username = username.Text,
                    Password = password.Text
                };
            }
            set
            {
                User user = value;
                username.Text = user.Username;
                password.Text = user.Password;
            }
        }

        public event EventHandler<EventArgs> SignIn = delegate { };
        public event EventHandler<EventArgs> ClearClick = delegate { };

        private void singInbtn_Click(object sender, EventArgs e)
        {
            SignIn.Invoke(sender, e);
        }

        private void clearbt_Click(object sender, EventArgs e)
        {
            ClearClick.Invoke(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A1.View.Interfaces;
using A1.Model;

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
            try
            {
                ClearClick.Invoke(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
            }
            MessageBox.Show("Ok");
        }
    }
}

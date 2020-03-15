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
    public partial class SignUpControl : UserControl, ISignUpControl
    {
        public SignUpControl()
        {
            InitializeComponent();
        }

        public User User
        {
            get
            {
                return new User
                {
                    Name = name.Text,
                    Lastname = lastname.Text,
                    Email = email.Text,
                    Username = username.Text,
                    Password = password.Text
                };
            }
            set
            {
                User user = value;
                name.Text = user.Name;
                lastname.Text = user.Lastname;
                email.Text = user.Email;
                username.Text = user.Username;
                password.Text = user.Password;
            }
        }

        public event EventHandler<EventArgs> SaveClick = delegate { };
        public event EventHandler<EventArgs> ClearClick = delegate { };

        private void savebtn_Click(object sender, EventArgs e)
        {
            SaveClick.Invoke(sender, e);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearClick.Invoke(sender, e);
        }
    }
}

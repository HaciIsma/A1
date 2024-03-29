﻿using A1.View.Interfaces;
using A1.View.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public ISignUpControl SignUpControl => signUpControl;
        public ISignInControl SignInControl => signInControl;
    }
}

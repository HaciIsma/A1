using A1.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1.Presenter
{
    class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly SignInSubPresenter signInView;
        private readonly SignUpSubPresenter signUpView;

        public MainPresenter(IMainView view)
        {
            mainView = view;
            signInView = new SignInSubPresenter(view.SignInControl);
            signUpView = new SignUpSubPresenter(view.SignUpControl);
        }
    }
}

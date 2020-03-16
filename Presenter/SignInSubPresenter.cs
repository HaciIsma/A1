using A1.View.Interfaces;
using System;

namespace A1.Presenter
{
    class SignInSubPresenter
    {
        private readonly ISignInControl view;
        public SignInSubPresenter(ISignInControl view)
        {
            this.view = view;
            this.view.SignIn += View_SignIn;
            this.view.ClearClick += View_ClearClick;
        }

        private void View_ClearClick(object sender, EventArgs e)
        {
            this.view.User = new Model.User { };
        }

        private void View_SignIn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

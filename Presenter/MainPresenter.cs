using A1.View.Interfaces;

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

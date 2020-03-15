using A1.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.Presenter
{
    class SignUpSubPresenter
    {
        private readonly ISignUpControl view;
        public SignUpSubPresenter(ISignUpControl view)
        {
            this.view = view;
            this.view.SaveClick += View_SaveClick;
            this.view.ClearClick += View_ClearClick;
        }

        private void View_ClearClick(object sender, EventArgs e)
        {
            this.view.User = new Model.User { };
        }

        private void View_SaveClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

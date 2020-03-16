using A1.Model;
using System;

namespace A1.View.Interfaces
{
    public interface ISignInControl
    {
        event EventHandler<EventArgs> SignIn;
        event EventHandler<EventArgs> ClearClick;
        User User { get; set; }
    }
}

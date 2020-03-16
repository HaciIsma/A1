using A1.Model;
using System;

namespace A1.View.Interfaces
{
    public interface ISignUpControl
    {
        event EventHandler<EventArgs> SaveClick;
        event EventHandler<EventArgs> ClearClick;
        User User { get; set; }
    }
}

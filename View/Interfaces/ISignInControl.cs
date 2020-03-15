using A1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.View.Interfaces
{
    public interface ISignInControl
    {
        event EventHandler<EventArgs> SignIn;
        event EventHandler<EventArgs> ClearClick;
        User User { get; set; }
    }
}

using A1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.View.Interfaces
{
    public interface ISignUpControl
    {
        event EventHandler<EventArgs> SaveClick;
        event EventHandler<EventArgs> ClearClick;
        User User { get; set; }
    }
}

using A1.View.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.View.Interfaces
{
    public interface IMainView
    {
        ISignUpControl SignUpControl { get; }
        ISignInControl SignInControl { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameWork.Commands.Actions.Interfaces
{
    public interface IRegister
    {
        void Register(string username, string password);
    }
}

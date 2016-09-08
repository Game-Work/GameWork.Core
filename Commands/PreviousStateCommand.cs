using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameWork.Commands.Interfaces;
using GameWork.States.Interfaces;

namespace GameWork.Commands
{
    /// <summary>
    /// Command to call the next state
    /// </summary>
    public struct PreviousStateCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var state = (IState)parameter;
            state.PreviousState();
        }
    }
}

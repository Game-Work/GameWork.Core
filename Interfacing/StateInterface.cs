using System.Collections.Generic;
using GameWork.Commands;
using GameWork.Commands.Interfaces;

namespace GameWork.Interfacing
{
    public abstract class StateInterface : ICommandInterface
    {
        private readonly CommandQueue _commandQueue = new CommandQueue();
        
        public bool HasCommands
        {
            get { return _commandQueue.HasCommands; }
        }

        public ICommand TakeFirstCommand()
        {
            return _commandQueue.TakeFirstCommand();
        }

        public ICommand[] TakeAllCommands()
        {
            return TakeAllCommands();
        }
        
        public abstract void Enter();

        public abstract void Exit();

        protected void EnqueueCommand(ICommand command)
        {
            _commandQueue.AddCommand(command);
        }

        protected void EnqueueCommands(IEnumerable<ICommand> commands)
        {
            _commandQueue.AddCommands(commands);
        }
    }
}

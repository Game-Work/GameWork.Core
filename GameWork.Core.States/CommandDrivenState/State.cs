using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States.CommandDrivenState
{
    public abstract class State : State<ICommand>
    {
        protected State(ITakeOnlyCommandQueue<ICommand> commandQueue, IStateTransition[] transitions) : base(commandQueue, transitions)
        {
        }
    }

    public abstract class State<TCommand> : States.State
        where TCommand : ICommand
    {
        protected readonly ITakeOnlyCommandQueue<TCommand> CommandQueue;

        protected State(ITakeOnlyCommandQueue<TCommand> commandQueue, IStateTransition[] transitions) : base(transitions)
        {
            CommandQueue = commandQueue;
        }
    }
}

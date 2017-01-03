using GameWork.Core.Commands.Interfaces;
using GameWork.Core.Interfaces;

namespace GameWork.Core.States.CommandDrivenState
{
    public abstract class CommandWriter : StateCommandWriter<ICommand>
    {
        protected CommandWriter(IWriteOnlyCommandQueue<ICommand> commandQueue) : base(commandQueue)
        {
        }
    }

    public abstract class StateCommandWriter<TCommand> : IInitializable, IEnterable, ITickable
        where TCommand : ICommand
    {
        protected readonly IWriteOnlyCommandQueue<TCommand> CommandQueue;

        protected StateCommandWriter(IWriteOnlyCommandQueue<TCommand> commandQueue)
        {
            CommandQueue = commandQueue;
        }

        public virtual void Initialize()
        {
        }

        public virtual void Terminate()
        {
        }

        public virtual void Enter()
        {
        }

        public virtual void Exit()
        {
        }

        public virtual void Tick(float deltaTime)
        {
        }
    }
}

namespace GameWork.Commands.Interfaces
{
    public interface ICommand : ICommand<ICommandAction>
    {
    }
        
    public interface ICommand<TCommandAction>
        where TCommandAction : ICommandAction
    {
        void Execute(TCommandAction parameter);
    }
}
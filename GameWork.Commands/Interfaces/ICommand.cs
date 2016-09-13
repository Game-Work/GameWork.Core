namespace GameWork.Commands.Interfaces
{
    public interface ICommand
    {
    }

    public interface ICommand<TCommandParameter> : ICommand
    {
        void Execute(TCommandParameter parameter);
    }
}
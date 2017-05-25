namespace GameWork.Core.Commands.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommand
    {
    }

    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommand<TCommandAction> : ICommand
        where TCommandAction : ICommandAction
    {
        void Execute(TCommandAction implementor);
    }
}
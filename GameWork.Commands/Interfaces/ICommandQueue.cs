namespace GameWork.Commands.Interfaces
{
    public interface ICommandInterface
    {
        bool HasCommands { get; }

        ICommand TakeFirstCommand();

        ICommand[] TakeAllCommands();
    }
}
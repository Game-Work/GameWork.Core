namespace GameWork.Commands.Interfaces
{
    public interface ICommandQueue
    {
        bool HasCommands { get; }

        ICommand TakeFirstCommand();

        ICommand[] TakeAllCommands();
    }
}
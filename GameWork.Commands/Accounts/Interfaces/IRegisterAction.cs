using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts.Interfaces
{
    public interface IRegisterAction : ICommandAction
    {
        void Register(string username, string password);
    }
}

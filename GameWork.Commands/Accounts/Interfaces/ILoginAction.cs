using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts.Interfaces
{
    public interface ILoginAction : ICommandAction
    {
        void Login(string username, string password);
    }
}

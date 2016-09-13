using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts.Interfaces
{
    public interface ILogoutAction : ICommandAction
    {
        void Logout();
    }
}

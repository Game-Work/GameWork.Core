using GameWork.Commands.Accounts.Interfaces;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts
{
    public class LogoutCommand : ICommand<ILogoutAction>
    {
        public void Execute(ILogoutAction implementor)
        {
            implementor.Logout();
        }
    }
}

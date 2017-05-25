using GameWork.Core.Commands.Accounts.Interfaces;
using GameWork.Core.Commands.Interfaces;

namespace GameWork.Core.Commands.Accounts
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public class LogoutCommand : ICommand<ILogoutAction>
    {
        public void Execute(ILogoutAction implementor)
        {
            implementor.Logout();
        }
    }
}

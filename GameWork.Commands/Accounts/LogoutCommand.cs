using GameWork.Commands.Accounts.Interfaces;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts
{
    public class LogoutCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var castParameter = (ILogoutAction)parameter;
            castParameter.Logout();
        }
    }
}

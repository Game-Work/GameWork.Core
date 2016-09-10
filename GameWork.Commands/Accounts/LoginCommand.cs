using GameWork.Commands.Accounts.Interfaces;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts
{
    public struct LoginCommand : ICommand
    {
        private readonly string _username;
        private readonly string _password;

        public LoginCommand(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void Execute(object parameter)
        {
            var castParameter = (ILoginAction)parameter;
            castParameter.Login(_username, _password);
        }
    }
}

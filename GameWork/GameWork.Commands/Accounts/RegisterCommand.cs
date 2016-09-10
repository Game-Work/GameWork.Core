using GameWork.Commands.Accounts.Interfaces;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts
{
    public struct RegisterCommand : ICommand
    {
        private readonly string _username;
        private readonly string _password;

        public RegisterCommand(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void Execute(object parameter)
        {
            var castParameter = (IRegisterAction)parameter;
            castParameter.Register(_username, _password);
        }
    }
}

using GameWork.Commands.Actions.Interfaces;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands
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
            var castParameter = (ILogin)parameter;
            castParameter.Login(_username, _password);
        }
    }
}

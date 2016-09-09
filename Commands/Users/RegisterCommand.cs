using GameWork.Commands.Actions.Interfaces;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Users
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
            var castParameter = (IRegister)parameter;
            castParameter.Register(_username, _password);
        }
    }
}

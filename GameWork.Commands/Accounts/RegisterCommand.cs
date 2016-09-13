using GameWork.Commands.Accounts.Interfaces;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts
{
    public struct RegisterCommand : ICommand<IRegisterAction>
    {
        private readonly string _username;
        private readonly string _password;

        public RegisterCommand(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void Execute(IRegisterAction implementor)
        {
            implementor.Register(_username, _password);
        }
    }
}

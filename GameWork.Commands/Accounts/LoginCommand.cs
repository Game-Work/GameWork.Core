using GameWork.Commands.Accounts.Interfaces;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Accounts
{
    public class LoginCommand : ICommand<ILoginAction>
    {
        private readonly string _username;
        private readonly string _password;

        public LoginCommand(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void Execute(ILoginAction implementor)
        {
            implementor.Login(_username, _password);
        }
    }
}

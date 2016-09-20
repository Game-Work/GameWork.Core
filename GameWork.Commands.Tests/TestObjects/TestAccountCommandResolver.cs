using GameWork.Commands.Accounts;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Tests.TestObjects
{
	public class TestAccountCommandResolver : CommandResolver
	{
		private readonly TestAccountContoller _accountController;

		public TestAccountCommandResolver(TestAccountContoller accountContoller)
		{
			_accountController = accountContoller;
		}

		public override void ProcessCommand(ICommand command)
		{
			var registerCommand = command as RegisterCommand;
			if (registerCommand != null)
			{
				registerCommand.Execute(_accountController);
				return;
			}

			var loginCommand = command as LoginCommand;
			if (loginCommand != null)
			{
				loginCommand.Execute(_accountController);
				return;
			}

			var logoutCommand = command as LogoutCommand;
			if (logoutCommand != null)
			{
				logoutCommand.Execute(_accountController);
				return;
			}
		}
	}
}

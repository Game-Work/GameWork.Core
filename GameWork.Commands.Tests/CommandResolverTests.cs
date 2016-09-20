using GameWork.Commands.Accounts;
using GameWork.Commands.Tests.TestObjects;

namespace GameWork.Commands.Tests
{
    public class CommandResolverTests
    {
		private const string Username = "testUser";
		private const string Password = "testPassword";

		private readonly TestAccountContoller _accountContoller = new TestAccountContoller(Username, Password);
	    private readonly TestAccountCommandResolver _commandResolver;

	    public CommandResolverTests()
	    {
		    _commandResolver = new TestAccountCommandResolver(_accountContoller);
	    }

		public void TestRegister()
		{
			//Assert.False(_accountContoller.IsRegistered);

			var command = new RegisterCommand(Username, Password);
			_commandResolver.ProcessCommand(command);

			//Assert.True(_accountContoller.IsRegistered);
		}

		public void TestLogin()
		{
			//Assert.False(_accountContoller.IsLoggedIn);

			var command = new LoginCommand(Username, Password);
			_commandResolver.ProcessCommand(command);

			//Assert.True(_accountContoller.IsLoggedIn);
		}

		public void TestLogout()
		{
			//Assert.False(_accountContoller.IsLoggedOut);

			var command = new LogoutCommand();
			_commandResolver.ProcessCommand(command);

			//Assert.True(_accountContoller.IsLoggedOut);
		}
	}
}
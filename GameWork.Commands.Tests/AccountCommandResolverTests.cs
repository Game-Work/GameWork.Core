using GameWork.Commands.Accounts;
using GameWork.Commands.Tests.TestObjects;
using NUnit.Framework;

namespace GameWork.Commands.Tests
{
    public class AccountCommandResolverTests
    {
		private const string Username = "testUser";
		private const string Password = "testPassword";

		private readonly TestAccountContoller _accountContoller = new TestAccountContoller(Username, Password);
	    private readonly TestAccountCommandResolver _commandResolver;

	    public AccountCommandResolverTests()
	    {
		    _commandResolver = new TestAccountCommandResolver(_accountContoller);
	    }

		[Test]
		public void TestRegister()
		{
			Assert.False(_accountContoller.IsRegistered);

			var command = new RegisterCommand(Username, Password);
			_commandResolver.ProcessCommand(command);

			Assert.True(_accountContoller.IsRegistered);
		}

		[Test]
		public void TestLogin()
		{
			Assert.False(_accountContoller.IsLoggedIn);

			var command = new LoginCommand(Username, Password);
			_commandResolver.ProcessCommand(command);

			Assert.True(_accountContoller.IsLoggedIn);
		}

		[Test]
		public void TestLogout()
		{
			Assert.False(_accountContoller.IsLoggedOut);

			var command = new LogoutCommand();
			_commandResolver.ProcessCommand(command);

			Assert.True(_accountContoller.IsLoggedOut);
		}
	}
}
using GameWork.Core.Commands.Interfaces;

namespace GameWork.Core.Commands.Accounts.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface IRegisterAction : ICommandAction
    {
        void Register(string username, string password);
    }
}

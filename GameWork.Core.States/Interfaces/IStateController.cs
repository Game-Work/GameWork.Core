namespace GameWork.Core.States.Interfaces
{
	public interface IStateController
	{
		string ActiveStateName { get; }
		
		void Initialize(string startStateName);

		void Terminate();
	}
}

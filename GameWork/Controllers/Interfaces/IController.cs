namespace GameWork.Controllers.Interfaces
{
	public interface IController
	{
		bool IsActive { get; }

		void Initialize();

		void Activate();

		void Tick(float deltaTime);

		void Deactivate();

		void Terminate();
	}
}
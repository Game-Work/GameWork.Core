using GameWork.Interfacing.Interfaces;

namespace GameWork.Interfacing.Interfaces
{
	public interface IInterfaceFactory<TInterface, TModel>
		where TInterface : IInterface
		where TModel : IInterfaceModel
	{
		void AddModel(TModel model);

		TInterface Create(string id);
	}

	public interface IInterfaceFactory
	{
		void AddModel(IInterfaceModel model);

		IInterface Create(string id);
	}
}
using System.IO;
using GameWork.Models.Interfaces;

namespace GameWork.IO.Interfaces
{
	public interface IJsonReader
	{
		TModel ConstructModel<TModel>(Stream stream) where TModel : IModel;
	}
}
using GameWork.Models.Interfaces;
using System.IO;

namespace GameWork.IO.Interfaces
{
	public interface IJsonReader
	{
		TModel ConstructModel<TModel>(Stream stream) where TModel : IModel;
	}
}
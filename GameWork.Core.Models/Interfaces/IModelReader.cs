using System.IO;

namespace GameWork.Core.Models.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface IModelReader
	{
		TModel ConstructModel<TModel>(Stream stream) where TModel : IModel;
	}
}
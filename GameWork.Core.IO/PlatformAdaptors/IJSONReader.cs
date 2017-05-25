using System.IO;
using GameWork.Core.Models.Interfaces;

namespace GameWork.Core.IO.PlatformAdaptors
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface IJsonReader
	{
		TModel ConstructModel<TModel>(Stream stream) where TModel : IModel;
	}
}
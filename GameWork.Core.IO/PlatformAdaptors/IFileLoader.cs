using System.IO;

namespace GameWork.Core.IO.PlatformAdaptors
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface IFileLoader
	{
		Stream Load(string path);
	}
}
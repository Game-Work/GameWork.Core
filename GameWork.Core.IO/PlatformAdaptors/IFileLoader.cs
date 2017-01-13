using System.IO;

namespace GameWork.Core.IO.PlatformAdaptors
{
	public interface IFileLoader
	{
		Stream Load(string path);
	}
}
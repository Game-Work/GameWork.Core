using System.IO;

namespace GameWork.IO.Interfaces
{
	public interface IFileLoader
	{
		Stream Load(string path);
	}
}
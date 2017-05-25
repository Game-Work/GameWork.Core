namespace GameWork.Core.IO
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public static class CSV
	{
		private const char Delimiter = ',';

		public static string[] ParseRow(string line)
		{
			return line.Split(Delimiter);
		}
	}
}
namespace GameWork.IO
{
	public static class CSV
	{
		private const char Delimiter = ',';

		public static string[] ParseRow(string line)
		{
			return line.Split(Delimiter);
		}
	}
}
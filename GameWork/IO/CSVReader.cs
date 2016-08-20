using System;
using System.IO;

namespace GameWork.IO
{
	public class CSVReader
	{
		private readonly StreamReader _reader;
		private bool _isDisposed = false;

		public CSVReader(Stream stream)
		{
			_reader = new StreamReader(stream);
		}  	

		public string[] ReadRow()
		{	
			var line = _reader.ReadLine();
			var cells = CSV.ParseRow(line);
			return cells;
		}

		public int Peek()
		{
			return _reader.Peek();
		}
	}
}
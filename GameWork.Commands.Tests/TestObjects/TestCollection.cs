using System.Collections.Generic;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands.Tests.TestObjects
{
	public class TestCollection<T> : List<T>, ICommandAction
	{
		public new void Add(T value)
		{
			base.Add(value);
		}
	}
}

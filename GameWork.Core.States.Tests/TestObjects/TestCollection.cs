using System.Collections.Generic;
using GameWork.Core.Commands.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestCollection<T> : List<T>, ICommandAction
	{
		public new void Add(T value)
		{
			base.Add(value);
		}
	}
}

using GameWork.Core.States.Interfaces;
using GameWork.Core.States.Tick;
using GameWork.Core.States.Tick.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateTwo : TickState
	{
		public const string StateName = "Two";
        
        public override string Name
		{
			get { return StateName; }
		}
    }
}

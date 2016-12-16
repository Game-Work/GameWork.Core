using GameWork.Core.Components.Interfaces;
using GameWork.Core.Math.Types;

namespace GameWork.Core.Components.Tests.TestObjects
{
    public class MockTransform : ITransform
    {
        public Vector3 Position { get; set; }
    }
}
using GameWork.Core.Components.Tests.TestObjects;
using NUnit.Framework;

namespace GameWork.Core.Components.Tests
{
    public class ComponentContainerTests
    {
        [Test]
        public void TestAddComponent()
        {
            var component = new TestMesh();
            var componentContainer = new ComponentContainer();

            Assert.IsTrue(componentContainer.TryAddComponent(component));
        }

        [Test]
        public void TestAddDuplicateComponent()
        {
            var component = new TestMesh();
            var componentContainer = new ComponentContainer();

            Assert.IsTrue(componentContainer.TryAddComponent(component));

            Assert.IsFalse(componentContainer.TryAddComponent(component));
        }

        [Test]
        public void TestHasComponent()
        {
            var component = new TestMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            Assert.IsTrue(componentContainer.HasComponent<TestMesh>());
        }

        [Test]
        public void TestDoesntHaveComponent()
        {
            var component = new TestMesh();
            var componentContainer = new ComponentContainer();

            Assert.IsFalse(componentContainer.HasComponent<TestMesh>());

            componentContainer.TryAddComponent(component);

            Assert.IsFalse(componentContainer.HasComponent<TestTransform>());
        }

        [Test]
        public void TestGetComponent()
        {
            var component = new TestMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            TestMesh gotComponent;
            Assert.IsTrue(componentContainer.TryGetComponent(out gotComponent));
            Assert.AreSame(component, gotComponent);
        }

        [Test]
        public void TestCantGetComponent()
        {
            var component = new TestMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            TestTransform gotComponent;
            Assert.IsFalse(componentContainer.TryGetComponent(out gotComponent));
            Assert.AreNotSame(component, gotComponent);
            Assert.IsNull(gotComponent);
        }

        [Test]
        public void TestRemoveComponentInstance()
        {
            var component = new TestMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            Assert.IsTrue(componentContainer.TryRemoveComponent(component));
            Assert.IsFalse(componentContainer.HasComponent<TestMesh>());
        }

        [Test]
        public void TestRemoveComponentType()
        {
            var component = new TestMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            Assert.IsTrue(componentContainer.TryRemoveComponent<TestMesh>());
            Assert.IsFalse(componentContainer.HasComponent<TestMesh>());
        }
    }
}

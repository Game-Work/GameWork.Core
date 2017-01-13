using GameWork.Core.Components.Tests.MockObjects;
using NUnit.Framework;

namespace GameWork.Core.Components.Tests
{
    public class ComponentContainerTests
    {
        [Test]
        public void AddComponent()
        {
            var component = new MockMesh();
            var componentContainer = new ComponentContainer();

            Assert.IsTrue(componentContainer.TryAddComponent(component));
        }

        [Test]
        public void AddDuplicateComponent()
        {
            var component = new MockMesh();
            var componentContainer = new ComponentContainer();

            Assert.IsTrue(componentContainer.TryAddComponent(component));

            Assert.IsFalse(componentContainer.TryAddComponent(component));
        }

        [Test]
        public void HasComponent()
        {
            var component = new MockMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            Assert.IsTrue(componentContainer.HasComponent<MockMesh>());
        }

        [Test]
        public void DoesntHaveComponent()
        {
            var component = new MockMesh();
            var componentContainer = new ComponentContainer();

            Assert.IsFalse(componentContainer.HasComponent<MockMesh>());

            componentContainer.TryAddComponent(component);

            Assert.IsFalse(componentContainer.HasComponent<MockTransform>());
        }

        [Test]
        public void GetComponent()
        {
            var component = new MockMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            MockMesh gotComponent;
            Assert.IsTrue(componentContainer.TryGetComponent(out gotComponent));
            Assert.AreSame(component, gotComponent);
        }

        [Test]
        public void CantGetComponent()
        {
            var component = new MockMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            MockTransform gotComponent;
            Assert.IsFalse(componentContainer.TryGetComponent(out gotComponent));
            Assert.AreNotSame(component, gotComponent);
            Assert.IsNull(gotComponent);
        }

        [Test]
        public void RemoveComponentInstance()
        {
            var component = new MockMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            Assert.IsTrue(componentContainer.TryRemoveComponent(component));
            Assert.IsFalse(componentContainer.HasComponent<MockMesh>());
        }

        [Test]
        public void RemoveComponentType()
        {
            var component = new MockMesh();
            var componentContainer = new ComponentContainer();

            componentContainer.TryAddComponent(component);

            Assert.IsTrue(componentContainer.TryRemoveComponent<MockMesh>());
            Assert.IsFalse(componentContainer.HasComponent<MockMesh>());
        }
    }
}

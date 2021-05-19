namespace CompositeTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Composite;
    using CompositeTest.Stubs;
    using Moq;

    [TestClass]
    public class CompositeTest1
    {
        Composite target;
        StubDrawable drawable;

        [TestInitialize]
        public void Setup()
        {
            drawable = new StubDrawable();
            target = new Composite();

        }

        [TestMethod]
        public void Add_ValidInput_InputAddedToList()
        {
            target.Add(drawable);
        }

        [TestMethod]
        public void Remove_ValidInput_RemovedFromList()
        {
            target.Remove(drawable);
        }

        public void GetChildren_MethodIsRan_GetListOfChildren()
        {
            var result = target.GetChildren();
            Assert.IsTrue(result != null);
        }

        public void Draw_MethodIsRan_ChildrenIsDrawn()
        {
            target.Draw();
        }
    }
}
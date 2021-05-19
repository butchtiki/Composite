namespace CompositeTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Composite;

    [TestClass]
    public class MountainTest
    {
        Mountain target;

        [TestInitialize]
        public void Setup()
        {
            target = new Mountain();
        }

        [TestMethod]
        public void Draw_MethodIsRan_PlayerIsDrawn()
        {
            target.Draw();
        }
    }
}

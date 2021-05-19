namespace CompositeTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Composite;

    [TestClass]
    public class PlayerTest
    {
        Player target;

        [TestInitialize]
        public void Setup()
        {
            target = new Player();
        }

        [TestMethod]
        public void Draw_MethodIsRan_PlayerIsDrawn()
        {
            target.Draw();
        }
    }
}

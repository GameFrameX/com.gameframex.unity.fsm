using GameFrameX.Fsm.Runtime;
using NUnit.Framework;

namespace GameFrameX.FSM.Tests
{
    internal class UnitTests
    {
        private FsmManager m_FsmManager;

        [SetUp]
        public void Setup()
        {
            m_FsmManager = new FsmManager();
        }

        [TearDown]
        public void Teardown()
        {
            if (m_FsmManager != null)
            {
                m_FsmManager.Shutdown();
                m_FsmManager = null;
            }
        }

        [Test]
        public void TestCreateFsm()
        {
            var owner = new object();
            IFsm<object> fsm = m_FsmManager.CreateFsm(owner, new TestIdleState());
            Assert.IsNotNull(fsm);
            Assert.AreEqual(1, m_FsmManager.Count);
            Assert.IsFalse(fsm.IsRunning);
        }

        [Test]
        public void TestStartAndDestroyFsm()
        {
            var owner = new object();
            IFsm<object> fsm = m_FsmManager.CreateFsm(owner, new TestIdleState());
            fsm.Start<TestIdleState>();
            Assert.IsTrue(fsm.IsRunning);
            Assert.AreEqual(nameof(TestIdleState), fsm.CurrentStateName);

            bool destroyed = m_FsmManager.DestroyFsm<object>();
            Assert.IsTrue(destroyed);
            Assert.AreEqual(0, m_FsmManager.Count);
        }

        [Test]
        public void TestHasFsm()
        {
            Assert.IsFalse(m_FsmManager.HasFsm<object>());

            var owner = new object();
            m_FsmManager.CreateFsm(owner, new TestIdleState());
            Assert.IsTrue(m_FsmManager.HasFsm<object>());
        }

        private class TestIdleState : FsmState<object>
        {
        }
    }
}

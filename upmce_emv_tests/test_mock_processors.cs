using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Ninject.Modules;
using upmce_emv_common;

namespace upmce_emv_tests
{
    [TestClass]
    public class test_mock_processors
    {

        private IProcessor testProcessor;

        public test_mock_processors()
        {
            var kernel = new StandardKernel();
            kernel.Load(System.Reflection.Assembly.GetExecutingAssembly());
            testProcessor = kernel.Get<IProcessor>();

        }
        [TestMethod]
        public void ConfirmTestSetup()
        {
            Assert.AreEqual(testProcessor.GetType().Name, typeof(TestAProcessor).Name);
        }

        [TestMethod]
        public void ConfirmProcessReturnsValue()
        {
            if(string.IsNullOrWhiteSpace(testProcessor.Process()))
            {
                Assert.Fail("Process call returned nothing");
            }
            
        }
    }

    public class TestEMVBinding:NinjectModule
    {
        public override void Load()
        {
            Bind<IProcessor>().To<TestAProcessor>();
        }
    }
}

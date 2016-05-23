using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Ninject.Modules;
using upmce_emv_common;
using System.Diagnostics;
using System.Reflection;
using System.Linq;

namespace upmce_emv_tests
{
    [TestClass]
    public class test_mock_processors
    {
        private IKernel kernel;

        public test_mock_processors()
        {
            kernel = new StandardKernel();
            kernel.Load(System.Reflection.Assembly.GetExecutingAssembly());         
        }
        [TestMethod]
        public void ConfirmTestSetup()
        {
            Assert.AreEqual(kernel.Get<IProcessor>().GetType().Name, typeof(TestAProcessor).Name);
        }

        [TestMethod]
        public void ConfirmProcessReturnsValue()
        {
            if(string.IsNullOrWhiteSpace(kernel.Get<IProcessor>().Process()))
            {
                Assert.Fail("Process call returned nothing");
            }
            
        }

        [TestMethod]
        public void TimeNinjectBinding()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(kernel.Get<IProcessor>().Process()))
                {
                    Assert.Fail("Process call returned nothing");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("There was an unexpected issue. Details: " + e.Message);
            }
        }

        [TestMethod]
        public void TimeLateBinding()
        {
            try
            {
                var dll = Assembly.LoadFile(string.Format(@"{0}\upmce_emv_tests.dll", Environment.CurrentDirectory));
                Type localType = typeof(TestAProcessor);

                localType = dll.GetTypes().Where(t => localType.IsAssignableFrom(t)).FirstOrDefault();

                IProcessor localProcessor = (TestAProcessor)Activator.CreateInstance(localType);
                if (string.IsNullOrWhiteSpace(localProcessor.Process()))
                {
                    Assert.Fail("Process call returned nothing");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("There was an unexpected issue. Details: " + e.Message);
            }
        }

        [TestMethod]
        public void TimeEarlyBinding()
        {
            try
            {
                IProcessor localProcessor = new TestAProcessor();
                if (string.IsNullOrWhiteSpace(localProcessor.Process()))
                {
                    Assert.Fail("Process call returned nothing");
                }
            }
            catch(Exception e)
            {
                Assert.Fail("There was an unexpected issue. Details: " + e.Message);
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

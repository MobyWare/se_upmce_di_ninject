using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using System.Configuration;
using upmce_emv_concreteA;
using upmce_emv_concreteB;
using upmce_emv_common;

namespace upmce_web_processor_client
{
    public class WebEMVBinding:NinjectModule
    {
        public override void Load()
        {
            switch (ConfigurationManager.AppSettings["Processor"])
            {
                case "A":
                    Bind<IProcessor>().To<ConcreteAProcessor>();
                    break;
                case "B":
                    Bind<IProcessor>().To<ConcreteBProcessor>();
                    break;
            }
            
        }
    }
}
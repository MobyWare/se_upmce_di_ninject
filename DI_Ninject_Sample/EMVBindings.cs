using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using upmce_emv_common;
using upmce_emv_concreteA;
using upmce_emv_concreteB;

namespace DI_Ninject_Sample
{
    public class EMVBindings:NinjectModule
    {

        public override void Load()
        {
            Bind<IProcessor>().To<ConcreteBProcessor>();
        }
    }
}

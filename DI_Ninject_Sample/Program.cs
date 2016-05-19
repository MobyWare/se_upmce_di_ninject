using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using upmce_emv_common;

namespace DI_Ninject_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
}

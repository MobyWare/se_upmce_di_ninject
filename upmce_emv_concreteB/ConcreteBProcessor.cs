using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upmce_emv_common;

namespace upmce_emv_concreteB
{
    public class ConcreteBProcessor : IProcessor
    {

        public ConcreteBProcessor() { }

        string IProcessor.Process()
        {
            return string.Format("Processed by {0}.", this.GetType().Name);
        }

        string IProcessor.Process(string processParams)
        {
            string processor = this.GetType().Name;
            return string.Format("Processed by {0} with parameters {1}", processor, processParams);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upmce_emv_common;

namespace upmce_emv_concreteA
{
    public class ConcreteAProcessor : IProcessor
    {
        string IProcessor.Process(string processParams)
        {
            string processor = this.GetType().Name;
            string processorResponse = string.Format("Processed by {0}.", processor);
            Console.WriteLine(processorResponse);
            return processorResponse;
        }
    }
}

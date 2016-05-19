using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upmce_emv_common
{
    public class BaseSalesProcessor
    {

        private readonly IProcessor salesProcessor;
        public BaseSalesProcessor(IProcessor processor)
        {
            this.salesProcessor = processor;
        }

        public void ProcessSalesTransaction(string processParams)
        {
            Console.WriteLine(this.salesProcessor.Process(processParams));
        }
    }
}

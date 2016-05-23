using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upmce_emv_common;
using upmce_emv_concreteA;
using upmce_emv_concreteB;

namespace upmce_emv_processor_factory
{

    public enum EMVProcessors { ProcessorA, ProcessorB};

    public class ProcessorFactory
    {
        private static object processorLock = new object();
        private static ProcessorFactory _instance = null;

        private ProcessorFactory() { }

        public static ProcessorFactory Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock(processorLock)
                    {
                        if(_instance == null)
                        {
                            _instance = new ProcessorFactory();
                        }
                    }
                }
                return _instance;
            }
        }

        public IProcessor GetProcessor(EMVProcessors processorRequested)
        {
            IProcessor processorReturned = null;
            switch(processorRequested)
            {
                case EMVProcessors.ProcessorA:
                    return new ConcreteAProcessor();
                case EMVProcessors.ProcessorB:
                    return new ConcreteBProcessor();
            }

            if(processorReturned == null)
            {
                throw new InvalidOperationException("Something went wrong constructing sales processor.");              
            }
            else
            {
                return processorReturned;
            }
        }

    }
}

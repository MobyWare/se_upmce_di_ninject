using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upmce_emv_common
{
    public interface IProcessor
    {
        string Process(string processParams);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using upmce_emv_common;
using Ninject;

namespace upmce_web_processor_client
{
    public partial class Default : System.Web.UI.Page
    {
        protected IProcessor salesProcessor;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Process_Handler(object sender, EventArgs e)
        {
            salesProcessor = ((IKernel)Application["ProcessorKey"]).Get<IProcessor>();
            MessageTextbox.Text = salesProcessor.Process();
        }
    }
}
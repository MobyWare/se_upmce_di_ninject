using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using upmce_emv_common;
using upmce_emv_processor_factory;

namespace upmce_web_processor_factory_client
{
    public partial class Default : System.Web.UI.Page
    {
        protected IProcessor salesProcessor;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Process_Handler(object sender, EventArgs e)
        {
            EMVProcessors processorSelected;
            if(!Enum.TryParse<EMVProcessors>(ProcessorDropdown.SelectedValue, true, out processorSelected))
            {
                throw new InvalidOperationException("You need to make a valid selection for the processor.");
            }
            else
            {
                salesProcessor = ProcessorFactory.Instance.GetProcessor(processorSelected);
            }
            
            if(MessageTextbox.Text.Length == 0)
            {
                MessageTextbox.Text = salesProcessor.Process();
            }
            else
            {
                MessageTextbox.Text += "\r\n" + salesProcessor.Process();
            }
            
        }

        protected void Clear_Handler(object sender, EventArgs e)
        {
            MessageTextbox.Text = string.Empty;
        }
    }
}
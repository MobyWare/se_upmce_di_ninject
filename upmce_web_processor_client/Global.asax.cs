using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Ninject;
using System.Diagnostics;

namespace upmce_web_processor_client
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Set the processor on app start up

            var kernel = new StandardKernel();
            kernel.Load(System.Reflection.Assembly.GetExecutingAssembly());
            Application["ProcessorKey"] = kernel;
            Debug.WriteLine(string.Format("The application started and it is {0} that processor is null.", kernel == null));
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("Session started");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
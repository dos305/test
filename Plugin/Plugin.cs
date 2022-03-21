using System;
using Microsoft.Xrm.Sdk;

namespace Plugin
{
    public class Plugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {

            IPluginExecutionContext context = (IPluginExecutionContext)
            serviceProvider.GetService(typeof(IPluginExecutionContext));
            Entity entity = (Entity)context.InputParameters["Target"];

            if (entity.Contains("crf5a_phonenumber"))
            {
                string num = (string)entity["crf5a_phonenumber"];

                if (num.Equals(null))
                {
                    entity["crf5a_isValidated"] = false;
                }

                else
                {
                    entity["crf5a_isValidated"] = true;
                }
            }

        }
    }
}

using System;

namespace nothinbutdotnetstore.web.core
{
    public class CommandUrl
    {
        public static string run<ApplicationBehaviour>()
        {
            return String.Format("{0}.uk", typeof(ApplicationBehaviour).Name);
        }
    }
}
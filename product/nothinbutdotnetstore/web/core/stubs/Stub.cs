using nothinbutdotnetstore.web.core.aspnet;

namespace nothinbutdotnetstore.web.core.stubs
{
    public static class Stub
    {
        public static ReturnType with<ReturnType>() where ReturnType : new()
        {
            return new ReturnType();
        }

        public static ReturnType until<ReturnType>(this ReturnType returnType, string dateTime)
            where ReturnType : new()
        {
            return new ReturnType();
        }
    }

}
using Nancy;

namespace KnockoutTest
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ =>
                           {
                               Response resp = View["Index"];
                               resp.ContentType += ";charset=utf-8";
                               return resp;
                           };
        }
    }
}
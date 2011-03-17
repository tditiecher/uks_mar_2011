using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace nothinbutdotnetstore.specs.utility
{
    public class ObjectFactory
    {
        public static HttpContext create_http_context()
        {
            return new HttpContext(create_request(), create_response());
        }

        public static IEnumerable<Item> create_items<Item>(int number_of_items)
            where Item : new()
        {
            return Enumerable.Range(1, number_of_items).Select(x => new Item());
        }

        static HttpRequest create_request()
        {
            return new HttpRequest("blah.aspx", "http://local/balh.aspx", string.Empty);
        }

        static HttpResponse create_response()
        {
            return new HttpResponse(new StringWriter());
        }
    }
}
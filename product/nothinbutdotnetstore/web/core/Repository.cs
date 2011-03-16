using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application
{
    public interface Repository
    {
        IEnumerable<Department> get_main_departments();
    }
}
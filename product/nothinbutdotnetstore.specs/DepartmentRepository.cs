using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application
{
    public interface DepartmentRepository
    {
        IEnumerable<Department> get_main_departments();
    }
}
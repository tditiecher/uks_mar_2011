using Machine.Specifications;
using developwithpassion.specifications.rhino;
using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
    public class ViewTheMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<ApplicationBehaviour,
                                            ViewTheMainDepartmentsInTheStore>
        {
        
        }

        [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
        public class when_run : concern
        {
            Establish c = () =>
            {
                department_repository = the_dependency<DepartmentRepository>();
            };

            Because b = () =>
                sut.process(request);

            It should_retrieve_the_departments_from_its_repository = () =>
                department_repository.received(x => x.get_main_departments());

            It should_get_the_view_that_can_handle_

            static Request request;
            static DepartmentRepository department_repository;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using developwithpassion.specifications.rhino;
using developwithpassion.specifications.extensions;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    public class CommandUrlSpecs
    {
        public abstract class concern : Observes
        {
        }

        public class when_passing_a_type_of_application_behaviour_to_run : concern
        {
            Because b = () =>
                result = CommandUrl.run<ApplicationBehaviour>();

            It should_return_the_url_for_that_type = () =>
                result.ShouldEqual("ApplicationBehaviour.uk");

            static string result;
        }
    }

}

 using System.Collections.Generic;
 using System.Linq;
 using Machine.Specifications;
 using developwithpassion.specifications.rhino;
 using developwithpassion.specifications.extensions;

namespace nothinbutdotnetstore.specs.utility
{   
    public class ObjectFactorySpecs
    {
        public abstract class concern : Observes
        {
        
        }

        public class when_requesting_to_generate_some_items : concern
        {
            Because b = () =>
                result = ObjectFactory.create_items<int>(100);

            It should_return_the_number_of_items_as_an_IEnumerable = () =>
                result.Count().ShouldEqual(100);

            static IEnumerable<int> result;
        }
    }
}

using System;

namespace nothinbutdotnetstore.utility.containers.basic
{
    public class DependencyCreationException : Exception
    {
        public Type type_that_could_not_be_created { get; private set; }

        public DependencyCreationException(Type type_that_could_not_be_created, Exception innerException) 
            : base("Oops", innerException)
        {
            this.type_that_could_not_be_created = type_that_could_not_be_created;
        }
    }
}
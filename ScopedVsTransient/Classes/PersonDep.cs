using System;

namespace ScopedVsTransient.Classes
{
    public class PersonDep
    {
        public Guid Id { get; }

        public PersonDep()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString() => $"Person: {Id}";
    }
}
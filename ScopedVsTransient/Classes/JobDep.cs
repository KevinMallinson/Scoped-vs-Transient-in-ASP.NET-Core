using System;

namespace ScopedVsTransient.Classes
{
    public class JobDep
    {
        public Guid Id { get; }

        public JobDep()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString() => $"Job: {Id}";
    }
}
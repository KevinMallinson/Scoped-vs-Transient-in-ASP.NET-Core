using System;

namespace ScopedVsTransient.Classes
{
    public class PetDep
    {
        public Guid Id { get; }

        public PetDep()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString() => $"Pet: {Id}";
    }
}

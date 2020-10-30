namespace ScopedVsTransient.Classes
{
    public class SampleService
    {
        private readonly PersonDep _personDep;
        private readonly PetDep _petDep;
        private readonly JobDep _jobDep;

        public SampleService(PersonDep personDep, PetDep petDep, JobDep jobDep)
        {
            _personDep = personDep;
            _petDep = petDep;
            _jobDep = jobDep;
        }

        public override string ToString() =>
            @$"SampleService Data:
                * {_personDep}
                * {_petDep}
                * {_jobDep}
            ";
    }
}

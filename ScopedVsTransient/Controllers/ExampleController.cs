using Microsoft.AspNetCore.Mvc;
using ScopedVsTransient.Classes;

namespace ScopedVsTransient.Controllers
{
    public class ExampleController : Controller
    {
        private readonly PersonDep _personDep;
        private readonly PetDep _petDep;
        private readonly JobDep _jobDep;
        private readonly SampleService _sampleService;

        public ExampleController(PersonDep personDep, PetDep petDep, JobDep jobDep, SampleService sampleService)
        {
            _personDep = personDep;
            _petDep = petDep;
            _jobDep = jobDep;
            _sampleService = sampleService;
        }

        [HttpGet("example")]
        public IActionResult Scoped()
        {
            return Ok(@$"
                {_personDep}
                {_petDep}
                {_jobDep}

                {_sampleService}
            ");
        }
    }
}

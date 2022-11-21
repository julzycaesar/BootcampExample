namespace BootcampExample.Controllers
{
  using Microsoft.AspNetCore.Mvc;

  [ApiController]
  [Route("[controller]")]
  public class BootcampScheduleController : ControllerBase
  {
    private readonly ILogger<BootcampScheduleController> _logger;
    private readonly BootcampScheduleRepository bootcampScheduleRepository;

    public BootcampScheduleController(ILogger<BootcampScheduleController> logger, BootcampScheduleRepository bootcampScheduleRepository)
    {
      _logger = logger;
      this.bootcampScheduleRepository = bootcampScheduleRepository;
    }

    [HttpGet(Name = "BootcampSchedule")]
    public IEnumerable<BootcampSchedule> Get()
    {
      return bootcampScheduleRepository.BootcampSchedules;
    }

    [HttpPost(Name = "BootcampSchedule")]
    public IActionResult AddSchedule(BootcampSchedule bootcampSchedule)
    {
      bootcampScheduleRepository.BootcampSchedules.Add(bootcampSchedule);
      return this.Ok(bootcampScheduleRepository.SaveChangesAsync());
    }
  }
}
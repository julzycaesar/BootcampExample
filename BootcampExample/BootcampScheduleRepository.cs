namespace BootcampExample
{
  using Microsoft.EntityFrameworkCore;

  public class BootcampScheduleRepository : DbContext
  {
    public BootcampScheduleRepository(DbContextOptions<BootcampScheduleRepository> options) 
      :base (options) 
    { 
    }

    public DbSet<BootcampSchedule> BootcampSchedules { get; set; }
  }
}

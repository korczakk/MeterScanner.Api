using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeterScanner.Infrastructure.Database
{
  public class MeterScannerDbContext : IdentityDbContext
  {
    public MeterScannerDbContext(DbContextOptions options)
      : base(options)
    {
    }
  }
}

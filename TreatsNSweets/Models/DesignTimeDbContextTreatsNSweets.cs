using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TreatsNSweets.Models
{
  public class TreatsNSweetsContextFactory : IDesignTimeDbContextFactory<TreatsNSweetsContext>
  {

    TreatsNSweetsContext IDesignTimeDbContextFactory<TreatsNSweetsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<TreatsNSweetsContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new TreatsNSweetsContext(builder.Options);
    }
  }
}
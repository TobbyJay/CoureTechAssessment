using CoureTechAssessment.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoureTechAssessment.Persistence
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<Country> Countries { get; set; }
		public DbSet<CountryDetail> CountryDetails { get; set; }
	}
}
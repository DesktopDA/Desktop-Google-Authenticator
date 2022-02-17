using API_WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_WebApplication1.Data
{ 
  public class ApartmentContext:DbContext
  {
    public ApartmentContext(DbContextOptions<ApartmentContext> options) : base(options)
      {

      }

    public DbSet<Apartment> Departamentos { get; set; }
  }



}

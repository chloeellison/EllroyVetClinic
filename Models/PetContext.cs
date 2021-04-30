using Microsoft.EntityFrameworkCore;

namespace EllroyVetClinic.Models
{
    public class PetContext : DbContext
    {
        public PetContext (DbContextOptions<PetContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pet {get; set;}
        public DbSet<Owner> Owner {get; set;}
        public DbSet<Veterinarian> Veterinarian {get; set;}
    }
}
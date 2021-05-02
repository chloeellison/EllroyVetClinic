using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;

namespace EllroyVetClinic.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new PetContext(serviceProvider.GetRequiredService<DbContextOptions<PetContext>>()))
            {
                if (db.Pet.Any())
                {
                    return;
                }

                db.Pet.AddRange(
                    new Pet
                    {
                        PetName = "Ellroy",
                        PetType = "Cat",
                        PetAge = 6,
                        Owner = Owner
                    }
                );
            }
        }
    }
}
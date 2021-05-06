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

                db.Veterinarian.AddRange(
                    new Veterinarian
                    {
                        VetFirst = "Andy",
                        VetLast = "Bernard",
                        Rating = 3,
                    },

                    new Veterinarian
                    {
                        VetFirst = "Pam",
                        VetLast = "Beesly",
                        Rating = 4,
                    },

                    new Veterinarian
                    {
                        VetFirst = "Dwight",
                        VetLast = "Schrute",
                        Rating = 1,
                    },

                    new Veterinarian
                    {
                        VetFirst = "Jim",
                        VetLast = "Halpert",
                        Rating = 4,
                    },

                    new Veterinarian
                    {
                        VetFirst = "Michael",
                        VetLast = "Scott",
                        Rating = 5,
                    },

                    new Veterinarian
                    {
                        VetFirst = "Meredith",
                        VetLast = "Palmer",
                        Rating = 1,
                    }
                );
                
                db.Pet.AddRange(
                    new Pet
                    {
                        PetName = "Ellroy",
                        PetType = "Cat",
                        PetAge = 6,
                        Owner = new Owner {OwnerFirst = "Chloe", OwnerLast = "Ellison", OwnerPhone = "704-7333"},
                        VeterinarianId = 5,
                    },

                    new Pet
                    {
                        PetName = "Epona",
                        PetType = "Cat",
                        PetAge = 15,
                        Owner = new Owner {OwnerFirst = "JJ", OwnerLast = "Ellison", OwnerPhone = "111-1111"},
                        VeterinarianId = 1,
                    },

                    new Pet
                    {
                        PetName = "Harper",
                        PetType = "Dog",
                        PetAge = 8,
                        Owner = new Owner {OwnerFirst = "Brandi", OwnerLast = "Carter", OwnerPhone = "222-2222"},
                        VeterinarianId = 2,
                    },

                    new Pet
                    {
                        PetName = "Myley",
                        PetType = "Dog",
                        PetAge = 11,
                        OwnerID = 1,
                        VeterinarianId = 5,
                    },

                    new Pet
                    {
                        PetName = "Ginger",
                        PetType = "Mule",
                        PetAge = 15,
                        Owner = new Owner {OwnerFirst = "Jere", OwnerLast = "Ellison", OwnerPhone = "444-4444"},
                        VeterinarianId = 3,
                    },

                    new Pet
                    {
                        PetName = "Belle",
                        PetType = "Horse",
                        PetAge = 12,
                        OwnerID = 4,
                        VeterinarianId = 4,
                    },

                    new Pet
                    {
                        PetName = "Tweetie",
                        PetType = "Bird",
                        PetAge = 5,
                        Owner = new Owner {OwnerFirst = "Kylo", OwnerLast = "Ren", OwnerPhone = "555-5555"},
                        VeterinarianId = 1,
                    },

                    new Pet
                    {
                        PetName = "Nemo",
                        PetType = "Fish",
                        PetAge = 1,
                        Owner = new Owner {OwnerFirst = "Obi-Wan", OwnerLast = "Kenobi", OwnerPhone = "565-5656"},
                        VeterinarianId = 2,
                    },

                    new Pet     
                    {
                        PetName = "Fido",
                        PetType = "Dog",
                        PetAge = 3,
                        OwnerID = 5,
                        VeterinarianId = 3,
                    },

                    new Pet     
                    {
                        PetName = "MooMoo",
                        PetType = "Hamster",
                        PetAge = 2,
                        OwnerID = 5,
                        VeterinarianId = 4,
                    },

                    new Pet     
                    {
                        PetName = "Buddy",
                        PetType = "Dog",
                        PetAge = 6,
                        Owner = new Owner {OwnerFirst = "Lauren", OwnerLast = "Acosta", OwnerPhone = "888-8888"},
                        VeterinarianId = 5,
                    },

                    new Pet     
                    {
                        PetName = "Beau",
                        PetType = "Cat",
                        PetAge = 2,
                        Owner = new Owner {OwnerFirst = "Josh", OwnerLast = "Witherspoon", OwnerPhone = "999-9999"},
                        VeterinarianId = 6,
                    },

                    new Pet     
                    {
                        PetName = "Max",
                        PetType = "Dog",
                        PetAge = 10,
                        OwnerID = 8,
                        VeterinarianId = 1,
                    },

                    new Pet     
                    {
                        PetName = "Rory",
                        PetType = "Hamster",
                        PetAge = 3,
                        Owner = new Owner {OwnerFirst = "Kim", OwnerLast = "Kardashian", OwnerPhone = "121-1212"},
                        VeterinarianId = 2,
                    },

                    new Pet     
                    {
                        PetName = "Leo",
                        PetType = "Fish",
                        PetAge = 1,
                        OwnerID = 1,
                        VeterinarianId = 3,
                    },

                    new Pet     
                    {
                        PetName = "ChooChoo",
                        PetType = "Hamster",
                        PetAge = 2,
                        Owner = new Owner {OwnerFirst = "Luke", OwnerLast = "Skywalker", OwnerPhone = "232-2323"},
                        VeterinarianId = 4,
                    },

                    new Pet     
                    {
                        PetName = "NeighNeigh",
                        PetType = "Horse",
                        PetAge = 11,
                        Owner = new Owner {OwnerFirst = "Kylie", OwnerLast = "Jenner", OwnerPhone = "343-3434"},
                        VeterinarianId = 5,
                    },

                    new Pet     
                    {
                        PetName = "Hank",
                        PetType = "Mule",
                        PetAge = 8,
                        Owner = new Owner {OwnerFirst = "Billy", OwnerLast = "Joel", OwnerPhone = "454-4545"},
                        VeterinarianId = 6,
                    },

                    new Pet     
                    {
                        PetName = "Marty",
                        PetType = "Mule",
                        PetAge = 9,
                        OwnerID = 13,
                        VeterinarianId = 6,
                    },

                    new Pet 
                    {
                        PetName = "Peanut",
                        PetType = "Hamster",
                        PetAge = 1,
                        Owner = new Owner {OwnerFirst = "Elton", OwnerLast = "John", OwnerPhone = "898-8989"},
                        VeterinarianId = 1,
                    },

                    new Pet     
                    {
                        PetName = "Doug",
                        PetType = "Cat",
                        PetAge = 6,
                        Owner = new Owner {OwnerFirst = "Mila", OwnerLast = "Kunis", OwnerPhone = "646-6464"},
                        VeterinarianId = 2,
                    },

                    new Pet     
                    {
                        PetName = "Link",
                        PetType = "Dog",
                        PetAge = 8,
                        Owner = new Owner {OwnerFirst = "Nicki", OwnerLast = "Minaj", OwnerPhone = "797-7979"},
                        VeterinarianId = 3,
                    },

                    new Pet     
                    {
                        PetName = "Morty",
                        PetType = "Snake",
                        PetAge = 6,
                        Owner = new Owner {OwnerFirst = "Jimmy", OwnerLast = "Kimmel", OwnerPhone = "535-5353"},
                        VeterinarianId = 4,
                    },

                    new Pet     
                    {
                        PetName = "Rick",
                        PetType = "Snake",
                        PetAge = 4,
                        OwnerID = 16,
                        VeterinarianId = 5,
                    },

                    new Pet     
                    {
                        PetName = "Lillie",
                        PetType = "Dog",
                        PetAge = 10,
                        Owner = new Owner {OwnerFirst = "Kareem", OwnerLast = "Dana", OwnerPhone = "123-1234"},
                        VeterinarianId = 6,
                    }
                );
            }
        }
    }
}
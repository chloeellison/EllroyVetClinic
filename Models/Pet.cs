using System;

namespace EllroyVetClinic.Models
{
    public class Pet
    {
        public int PetId {get; set;} // PRIMARY KEY
        public string PetName {get; set;}
        public string PetType {get; set;}
        public int PetAge {get; set;}

        public int OwnerID {get; set;} // Foreign key linking pet to owner
        public Owner Owner {get; set;} // Navigation Property

        public int VeterinarianId {get; set;} // Foreign key linking pet to veterinarian
        public Veterinarian Veterinarian {get; set;} // Navigation Property
    }
}
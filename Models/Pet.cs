using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EllroyVetClinic.Models
{
    public class Pet
    {
        public int PetId {get; set;} // PRIMARY KEY
        
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string PetName {get; set;}
        
        [Required]
        [StringLength(12, MinimumLength = 3)]
        public string PetType {get; set;}
        
        [Required]
        [Range(1,50)]
        public int PetAge {get; set;}

        public int OwnerID {get; set;} // Foreign key linking pet to owner
        public Owner Owner {get; set;} // Navigation Property

        public int VeterinarianId {get; set;} // Foreign key linking pet to veterinarian
        public Veterinarian Veterinarian {get; set;} // Navigation Property
    }
}
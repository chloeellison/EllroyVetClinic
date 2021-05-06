using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace EllroyVetClinic.Models
{
    public class Veterinarian
    {
        public int VeterinarianId {get; set;} // PRIMARY KEY
        
        [Required]
        [StringLength(60, MinimumLength=2)]
        public string VetFirst {get; set;}
        
        [Required]
        [StringLength(60, MinimumLength=2)]
        public string VetLast {get; set;}
        
        [Required]
        [Range(1,5)]
        public int Rating {get; set;}

        public List<Pet> Patients {get; set;} // Navigation Property. One vet can have many patients.
    }
}
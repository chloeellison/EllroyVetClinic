using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace EllroyVetClinic.Models
{
    public class Owner
    {
        public int OwnerID {get; set;} // PRIMARY KEY
        
        [Required]
        [StringLength(60, MinimumLength=2)]
        public string OwnerFirst {get; set;}
        
        [Required]
        [StringLength(60, MinimumLength=2)]
        public string OwnerLast {get; set;}
        
        [Required]
        [StringLength(60, MinimumLength=2)]
        public string OwnerPhone {get; set;}

        public List<Pet> Pets {get; set;} // Navigation Property. One owner can have many pets.
    }
}
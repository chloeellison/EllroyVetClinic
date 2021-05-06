using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace EllroyVetClinic.Models
{
    public class Veterinarian
    {
        public int VeterinarianId {get; set;} // PRIMARY KEY
        public string VetFirst {get; set;}
        public string VetLast {get; set;}
        public int Rating {get; set;}

        public List<Pet> Patients {get; set;} // Navigation Property. One vet can have many patients.
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PierresTreats.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        public string Name { get; set; }

        public List<FlavorTreat> JoinEntities { get; }
        public ApplicationUser User { get; set; }
    }
}
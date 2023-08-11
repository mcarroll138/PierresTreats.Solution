using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PierresTreats.Models
{
    public class Flavor
    {
        public int FlavorId { get; set; }
        public string Description { get; set; }

        public List<FlavorTreat> JoinEntities { get; }
        public ApplicationUser User { get; set; }
    }
}
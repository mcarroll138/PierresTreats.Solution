using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PierresTreats.Models
{
    public class Treats
    {
    public int TreatId { get; set; }
    public string Name {get; set;}

    public List<FlavorTreat> JoinEntities { get; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceExploreCrewService.DataLayer.Entities
{
    public class Shuttle
    {

        public int ShuttleId { get; set; }

        [Required]
        public string ShuttleName { get; set; }

        public int ShuttleTire { get; set; }

        public virtual Crew Crew { get; set; }
        
    }
}

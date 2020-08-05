using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceExploreCrewService.DataLayer.Entities
{
    public class Crew
    {
        public int CrewId { get; set; }
        public int CaptainId { get; set; }  
        public int ShuttleId { get; set; }
        public Captain Captain { get; set; }
        public virtual Shuttle Shuttle { get; set; }
        public virtual ICollection<Robot> Robots { get; set; }

    }
}

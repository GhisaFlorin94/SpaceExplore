using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceExploreCrewService.DataLayer.Entities
{
    public class Robot
    {
        public int RobotId { get; set; }
        public string RobotName { get; set; }

        public int ManufacturingYear { get; set; }

        public int CrewId { get; set; }

        public virtual Crew Crew { get; set; }
    }
}

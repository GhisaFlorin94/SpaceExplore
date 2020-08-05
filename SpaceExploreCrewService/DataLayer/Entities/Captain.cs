using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceExploreCrewService.DataLayer.Entities
{
    public class Captain
    {
        public int CaptainId { get; set; }

        [Required]
        public string CaptainName { get; set; }

        public virtual Crew Crew { get; set; }

    }
}

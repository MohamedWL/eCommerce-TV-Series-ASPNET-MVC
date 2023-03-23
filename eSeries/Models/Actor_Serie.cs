using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eSeries.Models
{
    public class Actor_Serie
    {
        public int SerieId { get; set; }
        public Serie Serie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}

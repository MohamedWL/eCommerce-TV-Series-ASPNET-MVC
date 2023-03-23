using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSeries.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace eSeries.Models
{
    public class Serie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; } 

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SerieCategory SerieCategory { get; set; } //enum imported from eSeries/Data/Enums/SerieCategory.cs

        //Relationship
        public List<Actor_Serie> Actors_Series { get; set; }

        //Rel with Streamer
        public int StreamerId { get; set; }
        [ForeignKey("StreamerId")]
        public Streamer Streamer { get; set; }

        //Rel with Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}

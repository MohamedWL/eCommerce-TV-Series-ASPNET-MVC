using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSeries.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eSeries.Models
{
    public class Serie
    {
        [Key]
        public int Id { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }

		[Display(Name = "Description")]
		public string Description { get; set; }

		[Display(Name = "Price")]
		public double Price { get; set; }

		[Display(Name = "Image URL")]
		public string ImageURL { get; set; }

		[Display(Name = "Start availability")]
		public DateTime StartDate { get; set; }

		[Display(Name = "End of availability")]
		public DateTime EndDate { get; set; }

		[Display(Name = "Category")]
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace eSeries.Models
{
    // For an actor we will need a profile picture (URL link so a string), his fullname and some bio
    public class Streamer
    {
        [Key] //our key is our Id. By default usually
        public int Id { get; set; }

		[Display(Name = "Logo")]
		public string LogoURL { get; set; }

		[Display(Name = "Streamer name")]
		public string Name { get; set; }

		[Display(Name = "Streamer's description")]
		public string Description { get; set; }

        //Relationships
        public List<Serie> Series { get; set; }

    }
}

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
        public string LogoURL { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<Serie> Series { get; set; }

    }
}

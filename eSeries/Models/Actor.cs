using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace eSeries.Models
{
    // For an actor we will need a profile picture (URL link so a string), his fullname and some bio
    public class Actor
    {
        [Key] //our key is our Id. By default usually
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Serie> Actors_Series { get; set; }
    }
}

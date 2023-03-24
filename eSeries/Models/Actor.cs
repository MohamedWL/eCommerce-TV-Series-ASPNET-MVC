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
        [Display(Name = "Profile Picture URL")] //useful for when we want to use the header names in the view
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Serie> Actors_Series { get; set; }
    }
}

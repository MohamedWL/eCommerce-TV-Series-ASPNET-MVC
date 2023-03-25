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
        [Required(ErrorMessage ="Profile picture is required.")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(50, MinimumLength =4, ErrorMessage = "Full Name must be between 4 and 50 characters long.")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required.")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Serie>? Actors_Series { get; set; }
    }
}

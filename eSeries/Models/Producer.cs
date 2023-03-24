using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eSeries.Models
{
    public class Producer
    {
        [Key] //Just like our Actor model
        public int Id { get; set; }

		[Display(Name = "Profile Picture URL")]
		public string ProfilePictureURL { get; set; }

		[Display(Name = "Full Name")]
		public string FullName { get; set; }

		[Display(Name = "Biography")]
		public string Bio { get; set; }
        
        //Relationship
        public List<Serie> Series  { get; set; }
    }
}

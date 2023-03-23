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
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        
        //Relationship
        public List<Serie> Series  { get; set; }
    }
}

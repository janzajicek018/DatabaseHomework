using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseHomework.Models
{
    public class Anime
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int Episodes { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<AnimeGenre> AnimeGenres { get; set; }
    }
}

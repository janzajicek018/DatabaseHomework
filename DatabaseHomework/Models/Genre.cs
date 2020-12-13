using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseHomework.Models
{
    public class Genre
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<AnimeGenre> AnimeGenres { get; set; }
    }
}

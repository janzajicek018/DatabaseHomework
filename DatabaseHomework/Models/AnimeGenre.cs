using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseHomework.Models
{
    public class AnimeGenre
    {
        public Anime Anime { get; set; }
        public Genre Genre { get; set; }
        public int AnimeID { get; set; }
        public int GenreID { get; set; }
    }
}

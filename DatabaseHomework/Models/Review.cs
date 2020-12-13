using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseHomework.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Mark { get; set; }
        public string Description { get; set; }
        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }
        [Required]
        public string UserID { get; set; }
        [ForeignKey("AnimeID")]
        public Anime Anime { get; set; }
        [Required]
        public int AnimeID { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniInsta
{
    internal class Post
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Text { get; set; }
        [Required]
        public string ImagePath { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }

}

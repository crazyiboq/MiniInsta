using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniInsta
{
    internal class Tag
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string TagName { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}

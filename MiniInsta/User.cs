using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniInsta
{
    internal class User
    {
        public int Id { get; set; }

        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsOpen { get; set; } = true;

        public bool Gender { get; set; } = true;

        public DateTime BirthDate { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();


    }
}

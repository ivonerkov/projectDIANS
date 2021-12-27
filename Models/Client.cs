using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDians.Models
{
    public class Client
    {
        public Client()
        {
            recipe = new List<Recipe>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Adress { get; set; }
        [Range(1,99,ErrorMessage="Must be between 1 and 99.")]
        public int Age { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Recipe> recipe{ get; set; }
    }
}
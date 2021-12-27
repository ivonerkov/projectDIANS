using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDians.Models
{
    public class Recipe
    {
        public Recipe()
        {
            clients = new List<Client>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Steps { get; set; }
        [Display(Name = "Description")]
        public string Desc { get; set; }
        public float Rating { get; set; }
        [Display(Name ="The image URL")]
        public string ImageUrl { get; set; }
        public virtual ICollection<Client> clients{ get; set; }
    }
}
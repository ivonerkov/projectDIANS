using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDians.Models
{
    public class RecipeRentals
    {
        public Recipe recipe{ get; set; }
        public List<Client> clients { get; set; }
        public RecipeRentals()
        {
            clients = new List<Client>();
        }
    }
}
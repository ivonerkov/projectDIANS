using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDians.Models
{
    public class ClientRecipe
    {
        public Recipe recipe { get; set; }
        public List<Client> Clients { get; set; }
        public int ClientId { get; set; }
        public int RecipeId { get; set; }
    }
}
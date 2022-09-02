using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace appHomeWork12
{
    internal class Diet
    {
        private string _name;
        private string _author;
        private string _code_diet;
        private List<Ingredient> _ingredients;

        [JsonProperty("diet_name")]
        public string Name { get; set; }
        [JsonProperty("diet_author")]
        public string Author { get; set; }
        [JsonProperty("diet_code")]
        public string CodeDiet { get; set; }
        [JsonProperty("diet_ingredient")]
        public List<Ingredient> Ingredients { get; set; }   

        public Diet(string name, string author, string codeDiet)
        {
            Name = name;
            Author = author;
            CodeDiet = codeDiet;
            Ingredients = new List<Ingredient>();   
        }

        public void AddIngredients(string name, double price, double energyCost, string manufacturer)
        {
            Ingredient ingr = new Ingredient(name, price, energyCost, manufacturer);
            Ingredients.Add(ingr);
        }
    }
}

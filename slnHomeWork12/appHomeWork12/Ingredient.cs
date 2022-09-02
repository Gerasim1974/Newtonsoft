using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace appHomeWork12
{
    internal class Ingredient
    {
        private string _name;   
        private double _price;
        private double _energy_cost;
        private string _manufacturer;

        public Ingredient(string name, double price, double energyCost, string manufacturer)
        {
            Name = name;
            Price = price;  
            EnergyCost = energyCost;    
            Manufacturer = manufacturer;    
        }

        [JsonProperty("ingr_name")]
        public string Name{ get; set; }
        [JsonProperty("ingr_pice")]
        public double Price{ get; set; }
        [JsonProperty("ingr_EnergiCost")]
        public double EnergyCost{ get; set; }
        [JsonProperty("ingr_manufactured")]
        public string Manufacturer{ get; set; }

    }
}

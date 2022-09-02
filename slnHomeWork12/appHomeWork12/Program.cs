
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace appHomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diet myDyet = new Diet("SportStrong", "StrongMan", "Cremlin234");
            myDyet.AddIngredients("chiken", 4.5, 70.17, "OAO ChickenFoot");
            myDyet.AddIngredients("mutton", 17.91, 150.29, "OOO MuttonFoot");
            myDyet.AddIngredients("beef", 15.39, 125.87, "ASC BeefFoot");

            String json = JsonConvert.SerializeObject(myDyet);  



            //Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            //using (StreamWriter sw = new StreamWriter(@"C:\WorkProgramm\temp\app12_JSonText")) 
            //using (JsonWriter writer = new JsonTextWriter(sw))
            //{
            //    serializer.Serialize(writer, myDyet);   
            //}

        }
    }
}
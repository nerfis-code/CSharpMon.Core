using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace CSharpMon.Core
{
    public static class Resources
    {
        /// <summary>
        /// Loads Species file data and convert to <c>Species</c> Object
        /// </summary>
        /// <param name="speciesName"></param>
        /// <returns><c>Species?</c></returns>
        public static Species? GetSpecies(string speciesName) {
            
            string path = Path.Combine(AppContext.BaseDirectory, "Resources", "Jsons","Species",$"{speciesName.ToUpper()}.json");
            string jsonString;
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            try
            {
                jsonString = File.ReadAllText(path);
            }
            catch
            {
                return null;
            }
            return JsonSerializer.Deserialize<Species>(jsonString, options);
        }
        public static byte[] GetImageBuffer(string imagePath)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Resources", "Images", imagePath);
            return File.Exists(path) ? File.ReadAllBytes(path) : throw new FileNotFoundException(path);
        }
    }
}

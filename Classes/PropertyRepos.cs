using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Course.Classes
{
    public class PropertyRepos : IEnumerable<Property>
    {
        private static List<Property> properties = new List<Property>();
        private static int propertyId = 1;

        public void AddProperty(Property property)
        {
            property.Id = propertyId;
            ++propertyId;
            properties.Add(property);

        }
        public static void SavingTheProperty(string path)
        {
            string jsonstring = "";
          
            foreach (var user in properties)
            {
                jsonstring += JsonSerializer.Serialize(user);
                jsonstring += "\n";
            }
            if (jsonstring != "")
                File.WriteAllText(path, jsonstring);
            else
                File.WriteAllText(path, jsonstring);
        }
        public static void ReadTheProperty(string path)
        {
       
            if (File.ReadLines(path).ToList() == null)
                properties= null;

            List<string> lines = new List<string>();
            properties.Clear();
            lines = File.ReadLines(path).ToList();
            foreach (string line in lines)
            {
                Property? user;
                user = JsonSerializer.Deserialize<Property>(line);
                propertyId = user.Id + 1;
                properties.Add(user);


            }



        }
        public static List<Property> GetAllProperties()
        {
            return properties;
        }

        public static Property GetPropertyById(int Id)
        {
            return properties.FirstOrDefault(p => p.Id == Id);
        }
       
        public void RemoveProperty(Property property)
        {
           
            properties.Remove(property);
        }

      

        public  IEnumerator GetEnumerator()
        {
            
            return properties.Where(p => p.IsAvailable).GetEnumerator();
        }
    }
}
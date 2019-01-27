using System;
using System.IO;
using System.Collections;
using LINQ_In_Manhattan.Classes;
using Newtonsoft.Json;
using System.Linq;

namespace LINQ_In_Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string dataPath = "../../../data.json";

            RootObject obj = ParseObj(dataPath);
            QueryNeighborhoods(obj);
            QueryNamedNeighborhoods(obj);
            QueryNonDup(obj);
            QueryUniqueNamed(obj);



           
        }

        public static RootObject ParseObj(string path)
        {
            try
            {
                string unParsed;
                using (StreamReader reader = new StreamReader(path))
                {
                    unParsed = reader.ReadToEnd();
                }

                RootObject rootObj = JsonConvert.DeserializeObject<RootObject>(unParsed);
                //JObject obj = JObject.Parse(unParsed);

                //Feature[] features = JsonConvert.DeserializeObject<Feature[]>(obj["features"].ToString());

                //FeatureCollection<Feature> featCol = new FeatureCollection<Feature>();
                //featCol.Features = features;
                return rootObj;

            }
            catch (Exception e)
            {
                Console.WriteLine("Could not parse object.");
                throw e;
            }
        }

        public static void QueryNeighborhoods(RootObject obj)
        {
            var neighborhoods = from feature in obj.features
                                select feature.Properties.Neighborhood;
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("All neighborhood values:");
            foreach (string neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }

        public static void QueryNamedNeighborhoods(RootObject obj)
        {
            var neighborhoods = from feature in obj.features
                                where feature.Properties.Neighborhood.Length > 0
                                select feature.Properties.Neighborhood;
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("All named neighborhoods:");
            foreach (string neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }
    
        public static void QueryNonDup(RootObject obj)
        {
            var neighborhoods = obj.features.Select(feature => feature.Properties.Neighborhood)
                                            .Distinct();
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("Non-duplicate neighborhoods");
            foreach (string neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }

        }

        public static void QueryUniqueNamed(RootObject obj)
        {
            var neighborhoods = obj.features.Select(feature => feature.Properties.Neighborhood)
                                            .Where(s => s.Length > 0)
                                            .Distinct();
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("Unique, named neighborhoods");
            foreach (string neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
        }
        
    }
}

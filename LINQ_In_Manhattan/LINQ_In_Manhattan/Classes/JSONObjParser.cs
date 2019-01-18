using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LINQ_In_Manhattan.Classes;

namespace LINQ_In_Manhattan.Classes
{
    public class JSONObjParser
    {
        private string path;

        public JSONObjParser(string dataPath)
        {
            path = dataPath;
        }

       

        
        public FeatureCollection<Feature> DeSerializeFeatures(string unParsed)
        {
            try
            {
                JObject obj = JObject.Parse(unParsed);

                Feature[] features = JsonConvert.DeserializeObject<Feature[]>(obj["features"].ToString());

                FeatureCollection<Feature> featCol = new FeatureCollection<Feature>();
                featCol.Features = features;
                return featCol;

            } catch (Exception e)
            {
                Console.WriteLine("Could not parse object.");
                throw e;
            }
        }
        
        public string ParseFileToString()
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string stringJSON = reader.ReadToEnd();
                    return stringJSON;
                }

            } catch(Exception e)
            {
                Console.WriteLine("Reading JSON file failed");
                throw e;
            }
        }


        




    }
}

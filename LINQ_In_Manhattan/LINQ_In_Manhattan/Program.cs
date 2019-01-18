using System;
using System.IO;
using System.Collections;
using LINQ_In_Manhattan.Classes;


namespace LINQ_In_Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string dataPath = "../../../data.json";
            JSONObjParser builder = new JSONObjParser(dataPath);
            FeatureCollection<Feature> collectiony = builder.DeSerializeFeatures(builder.ParseFileToString());

            
        }

        
    }
}

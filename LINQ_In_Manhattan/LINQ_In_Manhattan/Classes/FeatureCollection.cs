using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using LINQ_In_Manhattan.Classes;

namespace LINQ_In_Manhattan.Classes
{
    public class FeatureCollection<Feature> : IEnumerable
    {
        public Feature[] Features { get; set; }
        
        public IEnumerator GetEnumerator()
        {
            foreach(Feature feature in Features)
            {
                yield return feature;
            }
        }

        
    }
}

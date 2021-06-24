using System;
using System.Collections.Generic;
using System.Text;

namespace App14
{
    public class DataPoint
    {
        public DataPoint(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        //setting the name wile serializing to JSON
        public Nullable<int> X = null;
        //setting the name wile serializing to JSON
        public Nullable<int> Y = null;
        //setting the name wile serializing to JSON
        public Nullable<int> Z = null;
    }
}

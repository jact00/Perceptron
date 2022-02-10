using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Data
    {
        public double[] X { get; set; }
        public int Y { get; set; }

        public Data(int n)
        {
            X = new double[n];
        }
    }
}

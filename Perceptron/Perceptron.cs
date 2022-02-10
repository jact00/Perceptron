using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    class Perceptron
    {
        public double[] W { get; set; }
        public Perceptron(int n)
        {
            W = new double[n + 1];

            for(int i = 0; i < n + 1; i++)
            {
                W[i] = 0;
            }
        }
        public int Pw(double[] x)
        {
            double sum = 0;

            for(int i = 0; i < x.Length; i++)
            {
                sum += x[i] * W[i + 1];
            }
            sum -= W[0];

            return sum >= 0 ? 1 : 0;
        }

        public int Train(List<Data> trainingData, double learningRate, int maxAges, PictureBox canvas)
        {
            int count = 0;
            bool done = false;

            while(!done && count < maxAges)
            {
                done = true;
                for(int j = 0; j < trainingData.Count; j++)
                {
                    int error = trainingData[j].Y - Pw(trainingData[j].X);

                    if (error != 0)
                    {
                        done = false;
                        for(int i = 1; i < W.Length; i++)
                        {
                            W[i] = W[i] + (learningRate * error * trainingData[j].X[i - 1]);
                        }
                        W[0] = W[0] - (learningRate * error);

                        canvas.Refresh();
                    }
                }
                count++;
            }

            return count;
        }
    }
}

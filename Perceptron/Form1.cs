using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        private List<Data> Data;
        private Perceptron Perceptron;
        private float CanvasScale;
        private bool Eval;
        public Form1()
        {
            InitializeComponent();
            Data = new List<Data>();
            Perceptron = new Perceptron(2);
            CanvasScale = 10;
            Eval = false;

            btnEvaluate.Enabled = false;
            btnTrain.Enabled = false;
            tbLearningRate.Value = 0;
            nudAges.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Data data = new Data(2);
            Point location = Transform(Canvas, e.Location);

            data.X[0] = location.X / CanvasScale;
            data.X[1] = location.Y / CanvasScale;

            if (e.Button == MouseButtons.Left)
                data.Y = 1;
            else
                data.Y = 0;      

            Data.Add(data);
            Canvas.Refresh();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            
            float dotSize = 7;

            if(Eval)
            {
                for (int i = 0; i < Canvas.Width; i++)
                {
                    for (int j = 0; j < Canvas.Height; j++)
                    {
                        double[] x = new double[2];
                        x[0] = (double)i / CanvasScale;
                        x[1] = (double)j / CanvasScale;

                        Brush color = Perceptron.Pw(x) == 1 ? Brushes.Pink : Brushes.Cyan;
                        Point location = Transform(Canvas, new Point(i, j));

                        e.Graphics.FillRectangle(color, location.X, location.Y,1,1);
                    }
                }
                Eval = false;
            }

            foreach(Data data in Data)
            {
                Brush color = data.Y == 1 ? Brushes.Red : Brushes.Blue;
                Point location = new Point((int)(data.X[0] * CanvasScale), (int)(data.X[1] * CanvasScale));
                location = Transform(Canvas, location);

                e.Graphics.FillEllipse(color, location.X-(dotSize/2), location.Y-(dotSize/2), 
                    dotSize, dotSize);
                e.Graphics.DrawEllipse(Pens.Black, location.X - (dotSize / 2), location.Y - (dotSize / 2),
                    dotSize, dotSize);
            }

            if (Perceptron.W.All(i => i != 0))
            {
                int x = (int)Math.Round(CanvasScale * (Perceptron.W[0] - Perceptron.W[1]*20)/ Perceptron.W[2]);
                int y = (int)Math.Round(CanvasScale * Perceptron.W[0] / Perceptron.W[2]);
                Point a = Transform(Canvas, new Point(200, x));
                Point b = Transform(Canvas, new Point(0, y));

                lbW0.Text = "W0: " + Perceptron.W[0].ToString("0.##");
                lbW1.Text = "W1: " + Perceptron.W[1].ToString("0.##");
                lbW2.Text = "W2: " + Perceptron.W[2].ToString("0.##");
                lbW0.Refresh();
                lbW1.Refresh();
                lbW2.Refresh();

                e.Graphics.DrawLine(Pens.Green, a, b);
            }
        }

        private Point Transform(PictureBox pb, Point p)
        {
            return new Point(p.X, pb.Height - p.Y);
        }

        private void tbLearningRate_ValueChanged(object sender, EventArgs e)
        {
            lbLearningRate.Text = ((double)tbLearningRate.Value / 100).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnEvaluate.Enabled = false;
            btnTrain.Enabled = false;
            tbLearningRate.Value = 0;
            nudAges.Value = 0;
            Data.Clear();
            Perceptron = new Perceptron(2);

            lbW0.Text = "W0:";
            lbW1.Text = "W1:";
            lbW2.Text = "W2:";
            lbLearningRate.Text = "0";
            lbResult.Text = "";

            Canvas.Refresh();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Perceptron.W[0] = r.NextDouble() * 10;
            Perceptron.W[1] = r.NextDouble();
            Perceptron.W[2] = r.NextDouble();

            Canvas.Refresh();
            btnTrain.Enabled = true;
            btnEvaluate.Enabled = false;
            lbResult.Text = "";
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            double learningRate = (double)tbLearningRate.Value / 100;
            int maxAges = (int)nudAges.Value;

            Console.WriteLine(learningRate);
            Console.WriteLine(maxAges);

            lbResult.Text = "";
            tbLearningRate.Enabled = false;
            nudAges.Enabled = false;
            btnReset.Enabled = false;
            btnInitialize.Enabled = false;
            btnTrain.Enabled = false;
            btnEvaluate.Enabled = false;
            Canvas.Enabled = false;

            int ages = Perceptron.Train(Data, learningRate, maxAges, Canvas);

            tbLearningRate.Enabled = true;
            nudAges.Enabled = true;
            btnReset.Enabled = true;
            btnInitialize.Enabled = true;
            btnTrain.Enabled = true;
            Canvas.Enabled = true;
            
            if(ages == maxAges)
            {
                lbResult.Text = "El algoritmo no convergió.";
                lbResult.ForeColor = Color.Red;
            }
            else
            {
                lbResult.Text = "El algoritmo convergió después de " + ages.ToString() + " epocas.";
                lbResult.ForeColor = Color.Green;
                btnEvaluate.Enabled = true;
            }
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Eval = true;
            Canvas.Refresh();
        }
    }
}

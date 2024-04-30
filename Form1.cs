using System;
using System.Windows.Forms;

namespace Lab_8._3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int trials;
        int[] counts;
        double[] probabilities;

        const int NumOfEvents = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            Initialize();

            if (probabilities[4] < 0)
            {
                MessageBox.Show("Incorrect input!\nSum of pi must be < 1");
                return;
            }
            inp_p5.Value = (decimal)probabilities[4];

            MakeTrials();
            DrawBarchart();
        }

        private void Initialize()
        {
            trials = (int)input_NumOfTrials.Value;
            counts = new int[NumOfEvents];
            Array.Clear(counts, 0, NumOfEvents);

            probabilities = new double[NumOfEvents]
            {
                (double)inp_p1.Value,
                (double)inp_p2.Value,
                (double)inp_p3.Value,
                (double)inp_p4.Value,
                1
            };
            //Вычисление последней вероятности
            for (int i = 0; i < NumOfEvents - 1; i++) probabilities[4] -= probabilities[i];   

            chart1.Series[0].Points.Clear();
        }

        private void MakeTrials()
        {
            for (int i = 0; i < trials; i++)
            {
                var p = random.NextDouble();
                counts[GetEvent(p)]++;
            }
        }

        private int GetEvent(double p)
        {
            int i = 0;
            while (p >= 0)
            {
                p -= probabilities[i];
                i++;
            }

            return i - 1;
        }

        private void DrawBarchart()
        {
            for (int i = 0; i < NumOfEvents; i++)
            {
                var value = (float)counts[i] / trials;
                chart1.Series[0].Points.AddXY(i + 1, value);
            }
        }
    }
}

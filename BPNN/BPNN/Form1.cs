using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BPNN
{
    public partial class Form1 : Form
    {
        NeuralNet neuron;
        int numberOfClicks;
        int numberOfIterations;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            neuron = new NeuralNet(4,2,1);
            numberOfClicks = 0;
            numberOfIterations = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y = 1600;
            numberOfClicks++;
            label2.Text = numberOfClicks.ToString();
            label4.Text = y.ToString();
            label6.Text = (y * numberOfClicks).ToString();
            for(int x = 0; x < y; x++)
            {
            //1st
            neuron.setInputs(0, 0.0);
            neuron.setInputs(1, 0.0);
            neuron.setInputs(2, 0.0);
            neuron.setInputs(3, 0.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //2nd
            neuron.setInputs(0, 0.0);
            neuron.setInputs(1, 0.0);
            neuron.setInputs(2, 0.0);
            neuron.setInputs(3, 1.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //3rd
            neuron.setInputs(0, 0.0);
            neuron.setInputs(1, 0.0);
            neuron.setInputs(2, 1.0);
            neuron.setInputs(3, 0.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //4th
            neuron.setInputs(0, 0.0);
            neuron.setInputs(1, 0.0);
            neuron.setInputs(2, 1.0);
            neuron.setInputs(3, 1.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //5th
            neuron.setInputs(0, 0.0);
            neuron.setInputs(1, 1.0);
            neuron.setInputs(2, 0.0);
            neuron.setInputs(3, 0.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //6th
            neuron.setInputs(0, 0.0);
            neuron.setInputs(1, 1.0);
            neuron.setInputs(2, 0.0);
            neuron.setInputs(3, 1.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //7th
            neuron.setInputs(0, 0.0);
            neuron.setInputs(1, 1.0);
            neuron.setInputs(2, 1.0);
            neuron.setInputs(3, 0.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //8th
            neuron.setInputs(0, 0.0);
            neuron.setInputs(1, 1.0);
            neuron.setInputs(2, 1.0);
            neuron.setInputs(3, 1.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //9th
            neuron.setInputs(0, 1.0);
            neuron.setInputs(1, 0.0);
            neuron.setInputs(2, 0.0);
            neuron.setInputs(3, 0.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //10th
            neuron.setInputs(0, 1.0);
            neuron.setInputs(1, 0.0);
            neuron.setInputs(2, 0.0);
            neuron.setInputs(3, 1.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //11th
            neuron.setInputs(0, 1.0);
            neuron.setInputs(1, 0.0);
            neuron.setInputs(2, 1.0);
            neuron.setInputs(3, 0.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //12th
            neuron.setInputs(0, 1.0);
            neuron.setInputs(1, 0.0);
            neuron.setInputs(2, 1.0);
            neuron.setInputs(3, 1.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //13th
            neuron.setInputs(0, 1.0);
            neuron.setInputs(1, 1.0);
            neuron.setInputs(2, 0.0);
            neuron.setInputs(3, 0.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //14th
            neuron.setInputs(0, 1.0);
            neuron.setInputs(1, 1.0);
            neuron.setInputs(2, 0.0);
            neuron.setInputs(3, 1.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //15th
            neuron.setInputs(0, 1.0);
            neuron.setInputs(1, 1.0);
            neuron.setInputs(2, 1.0);
            neuron.setInputs(3, 0.0);
            neuron.setDesiredOutput(0, 0.0);
            neuron.learn();

            //16th
            neuron.setInputs(0, 1.0);
            neuron.setInputs(1, 1.0);
            neuron.setInputs(2, 1.0);
            neuron.setInputs(3, 1.0);
            neuron.setDesiredOutput(0, 1.0);
            neuron.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            neuron.setInputs(0, Convert.ToDouble(textBox1.Text));
            neuron.setInputs(1, Convert.ToDouble(textBox2.Text));
            neuron.setInputs(2, Convert.ToDouble(textBox3.Text));
            neuron.setInputs(3, Convert.ToDouble(textBox4.Text));
            neuron.run();
            textBox5.Text = "" + neuron.getOuputData(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (neuron != null)
            {
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        neuron.saveWeights(saveFileDialog1.FileName);
                        MessageBox.Show("Weights saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving weights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

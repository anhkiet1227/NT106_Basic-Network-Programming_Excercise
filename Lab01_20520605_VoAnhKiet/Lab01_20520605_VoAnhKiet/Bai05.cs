using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_20520605_VoAnhKiet
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        public static double calAveragePoint(double[] array)
        {
            double averagePoint = 0;
            for (int i = 0; i < 12; ++i)
            {
                averagePoint += array[i];
            }
            averagePoint /= 12;
            averagePoint = Math.Round(averagePoint, 2);
            return averagePoint;
        }

        public static double findMax(double[] array)
        {
            double maxValue = array[0];
            for (int i = 0; i < 12; ++i)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
            }
            return maxValue;
        }

        public static double findMin(double[] array)
        {
            double minValue = array[0];
            for (int i = 0; i < 12; ++i)
            {
                if (array[i] < minValue)
                    minValue = array[i];
            }
            return minValue;
        }

        public static int calPass(double[] array)
        {
            int countValuePass = 0;
            for (int i = 0; i < 12; ++i)
            {
                if (array[i] >= 5)
                    ++countValuePass;
            }    
            return countValuePass;
        }

        public static int callFail(double[] array)
        {
            int countValueFail = 0;
            for (int i = 0; i < 12; ++i)
            {
                if (array[i] < 5)
                    ++countValueFail;
            }
            return countValueFail;
        }

        public static string classifyStu(double averagePoint, double [] array)
        {
            string certificate = "";
            int under65 = 0;
            int under5 = 0;
            int under35 = 0;
            int under2 = 0;

            for (int i = 0; i < 12; ++i)
            {
                if (array[i] < 2)
                    ++under2;
                if (array[i] < 3.5)
                    ++under35;
                if (array[i] < 5)
                    ++under5;
                if (array[i] < 6.5)
                    ++under65;
            }

            if (under2 != 0)
            {
                certificate = "Kém";
            }
            if (averagePoint >= 3.5 && under2 == 0)
            {
                certificate = "Yếu";
            }    
            if (averagePoint >= 5 && under35 == 0)
            {
                certificate = "Trung Bình";
            }    
            if (averagePoint >= 6.5 && under5 == 0)
            {
                certificate = "Khá";
            }    
            if (averagePoint >= 8 && under65 == 0)
            {
                certificate = "Giỏi";
            }    
            return certificate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputDrawString;
            var drawArrayOfPoint = new string[] { };
            var arrayOfPoint = new double[] { };
            double averagePoint, maxPoint, minPoint;
            int countPass = 0;
            int countFail = 0;
            string certificate = "";

            try
            {
                inputDrawString = textBox1.Text.Trim();
                drawArrayOfPoint = inputDrawString.Split(' ');
                arrayOfPoint = drawArrayOfPoint.Select(double.Parse).ToArray();

                for (int i =0; i < 12; ++i)
                {
                    if (arrayOfPoint[i] < 0 || arrayOfPoint[i] > 10)
                    {
                        Error: MessageBox.Show("Caution: ERROR! Check your input again, the input and output were wrong!");
                    }
                }    
                
                //show result
                textBox8.Text = arrayOfPoint[0].ToString();
                textBox9.Text = arrayOfPoint[1].ToString();
                textBox10.Text = arrayOfPoint[2].ToString();
                textBox11.Text = arrayOfPoint[3].ToString();
                textBox12.Text = arrayOfPoint[4].ToString();
                textBox18.Text = arrayOfPoint[5].ToString();
                textBox17.Text = arrayOfPoint[6].ToString();
                textBox16.Text = arrayOfPoint[7].ToString();
                textBox15.Text = arrayOfPoint[8].ToString();
                textBox14.Text = arrayOfPoint[9].ToString();
                textBox13.Text = arrayOfPoint[10].ToString();
                textBox19.Text = arrayOfPoint[11].ToString();

                averagePoint = calAveragePoint(arrayOfPoint);
                textBox2.Text = averagePoint.ToString();

                maxPoint = findMax(arrayOfPoint);
                textBox4.Text = maxPoint.ToString();

                minPoint = findMin(arrayOfPoint);
                textBox6.Text = minPoint.ToString();

                countPass = calPass(arrayOfPoint);
                textBox5.Text = countPass.ToString();

                countFail = callFail(arrayOfPoint);
                textBox7.Text = countFail.ToString();

                certificate = classifyStu(averagePoint, arrayOfPoint);
                textBox3.Text = certificate;               

            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: ERROR! Check your input again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}

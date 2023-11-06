    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication
{
    internal class Program
    {

        public Program()
        {
            Console.WriteLine("This is a constructor");
        }

        static void Main(string[] args)
        {
            string s;
            float bw;
            float h;
            float bmi = 0;


       
            Console.WriteLine("Enter Your Gender (M or F): ");
            s = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter Your Body Weight (Kg) : ");
            bw = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Your Height (m) : ");
            h = Convert.ToSingle(Console.ReadLine());

            void maleBMI() 
            {
                bmi = bw / (h * h);

                if (bmi < 18.5)
                {
                    MessageBox.Show("Severly Underweight", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 18.5 && bmi <= 20.7)
                {
                    MessageBox.Show("Underweight", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 20.7 && bmi <= 26.4)
                {
                    MessageBox.Show("In Normal Range", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 26.4 && bmi <= 27.8)
                {
                    MessageBox.Show("Marginally Overweight", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 27.8 && bmi <= 31.1)
                {
                    MessageBox.Show("Overweight", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 31.1 && bmi <= 35)
                {
                    MessageBox.Show("Very Overweight or Obese", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 35 && bmi <= 40)
                {
                    MessageBox.Show("Severely Obese", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Heartattack", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            void femaleBMI()
            {

                bmi = bw / (h * h);

                if (bmi < 17.5)
                {
                    MessageBox.Show("Severly Underweight", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 17.5 && bmi <= 19.1)
                {
                    MessageBox.Show("Underweight", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 19.1 && bmi <= 25.8)
                {
                    MessageBox.Show("In Normal Range", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 25.8 && bmi <= 27.3)
                {
                    MessageBox.Show("Marginally Overweight", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 27.3 && bmi <= 32.3)
                {
                    MessageBox.Show("Overweight", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 32.3 && bmi <= 35)
                {
                    MessageBox.Show("Very Overweight or Obese", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bmi >= 35 && bmi <= 40)
                {
                    MessageBox.Show("Severely Obese", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Heartattack", "Your BMI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            switch (s)
            {
                case "M":
                    maleBMI();
                    break;

                case "F":
                    femaleBMI();
                    break;

                default:
                    Console.WriteLine("Unable to Identify");
                    break;
            }


            Program p1 = new Program();
        }




    }
}

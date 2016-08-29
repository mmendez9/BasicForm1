using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double textBox1_TextChanged()
        {
            string work = Console.ReadLine();
            double hwork = Convert.ToDouble(work);
            return hwork;
        }

        private double textBox2_TextChanged()
        {
            string pay = Console.ReadLine();
            double hpay;
            double.TryParse(pay, out hpay);
            return hpay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the gross pay
            double hwork = textBox1_TextChanged();
            double hpay = textBox2_TextChanged();
            double cal = (hwork * hpay);
            Console.WriteLine(hwork);
           // MessageBox.Show(String.Format("The Gross Pay is {0}", cal));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the data

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the program
            
        }

    }
}

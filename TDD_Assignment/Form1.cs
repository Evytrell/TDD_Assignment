using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD_Assignment
{
    public partial class Shapes : Form
    {
        public Shapes()
        {
            InitializeComponent();
        }

       private void label2_Click(object sender, EventArgs e)
       {

       }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var lth = double.Parse(tbLength.Text);
                var hgt = double.Parse(tbHeight.Text);
                var area = AreaOfTrapezium(lth, hgt);
                tbArea.Text = area.ToString();
            }
            catch (Exception exception)
            {

                tbArea.Text = "Try again later";
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public double AreaOfTrapezium(double length, double height)
        {
            var area = length * height * 0.5;
            return area;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

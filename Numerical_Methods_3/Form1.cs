using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_Methods_3
{
    public partial class Form1 : Form
    {
        const double Pi = 3.14;
        const double h = Pi / 7;

        public Form1()
        {
            InitializeComponent();
        }

        double f(double x)
        {
            return Math.Sin(x) * Math.Sqrt(x) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

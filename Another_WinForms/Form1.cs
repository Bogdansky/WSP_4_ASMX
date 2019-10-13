using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Another_WinForms
{
    public partial class Form1 : Form
    {
        Simplex simplex;
        public Form1()
        {
            InitializeComponent();
            simplex = new Simplex();
        }

        private A GetFirst()
        {
            return new A
            {
                S = textBox7.Text,
                F = float.TryParse(textBox8.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float f) ? f : default,
                K = int.TryParse(textBox9.Text, out int k) ? k : default
            };
        }

        private A GetSecond()
        {
            return new A
            {
                S = textBox10.Text,
                F = float.TryParse(textBox11.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float f) ? f : default,
                K = int.TryParse(textBox12.Text, out int k) ? k : default
            };
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var first = GetFirst();
            var second = GetSecond();
            var result = simplex.Sum(first, second);
            if (result == null)
                return;
            textBox13.Text = result.S;
            textBox14.Text = result.F.ToString();
            textBox15.Text = result.K.ToString();
        }
    }
}

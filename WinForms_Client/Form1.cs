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

namespace WinForms_Client
{
    public partial class Form1 : Form
    {
        SimplexReference.SimplexSoapClient client = null;

        public Form1()
        {
            InitializeComponent();
            firstS.Text = secondS.Text = "";
            client = new SimplexReference.SimplexSoapClient();
            client.Open();
        }

        void SetFirstA()
        {
            AStore.First = new SimplexReference.A
            {
                S = firstS.Text,
                K = int.TryParse(firstK.Text, out int k) ? k : default,
                F = float.TryParse(firstF.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float f) ? f : default
            };
            MessageBox.Show("First инициализировано");
        }

        void SetSecondA()
        {
            AStore.Second = new SimplexReference.A
            {
                S = secondS.Text,
                K = int.TryParse(secondK.Text, out int k) ? k : default,
                F = float.TryParse(secondF.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float f) ? f : default
            };
            MessageBox.Show("Second инициализировано");
        }

        void SetResult(SimplexReference.A result)
        {
            resultS.Text = result.S;
            resultK.Text = result.K.ToString();
            resultF.Text = result.F.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetFirstA();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SetSecondA();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (AStore.First == null)
            {
                MessageBox.Show("First не инициализирован");
                return;
            }
            if (AStore.Second == null)
            {
                MessageBox.Show("Second не инициализирован");
                return;
            }
            var result = client.Sum(AStore.First, AStore.Second);
            try
            {
                SetResult(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

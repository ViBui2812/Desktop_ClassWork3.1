using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_ClassWork3._1
{
    public partial class Form1 : Form
    {
        string option;
        double result;
        double soA;
        double soB;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnCong_CheckedChanged(object sender, EventArgs e)
        {
            option = "+";
        }

        private void rbtnTru_CheckedChanged(object sender, EventArgs e)
        {
            option = "-";
        }

        private void rbtnNhan_CheckedChanged(object sender, EventArgs e)
        {
            option = "*";
        }

        private void rbtnChia_CheckedChanged(object sender, EventArgs e)
        {
            option = "/";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            soA = double.Parse(txtA.Text);
            soB = double.Parse(txtB.Text);
            switch(option)
            {
                case ("+"):
                    {
                        result = soA + soB; break;
                    }
                case ("-"):
                    {
                        result = soA - soB; break;
                    }
                case ("*"): 
                    {
                        result = soA * soB; break;
                    }
                case ("/"):
                    {
                        result = soA / soB; break;
                    }
            }
            listBox1.Items.Clear();
            if (chbBinhphuong.Checked)
                result = Math.Pow(result, 2);
            if (chbLamtron.Checked)
                result =Math.Round(result, 2);
            listBox1.Items.Add(result);
        }

        private void chbBinhphuong_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chbLamtron_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chbDele_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

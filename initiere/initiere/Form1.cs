using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace initiere
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void ex1()
        {
            //string x = "ceva";
            //string y = "altceva";

            ////concatenare  "3"+"4"="34"

            //MessageBox.Show(x + y);

            int nr1 = Int32.Parse(txtNr1.Text);
            int nr2 = Int32.Parse(txtNr2.Text);

            int suma = nr1 + nr2;

            MessageBox.Show(nr1 +"+"+nr2+"="+suma);

        }
        public void ex2()
        {
            int nr3 = Int32.Parse(txtnr3.Text);
            int nr4 = Int32.Parse(txtnr4.Text);
            int diferenta1 = nr3 - nr4;
            MessageBox.Show(nr3 + "-" + nr4 + "=" + diferenta1);
        }

        public void ex3()
        {
            //int nr5 = Int32.Parse(txt.Text);
            //int nr6 = Int32.Parse(txtNR6.Text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtNr1.Text + txtNr2.Text);

            ex1();
        }

        private void start_Click(object sender, EventArgs e)
        {
            ex2();
        }

        private void txtNr2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }
    }
}

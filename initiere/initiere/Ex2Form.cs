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
    public partial class Ex2Form : Form
    {
        public Color initial;
        public Font font;

        public Ex2Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            font = lblProba.Font;
            lblProba.Font = new Font("Segoe UI", 24);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initial = lblProba.ForeColor;
            lblProba.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           lblProba.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            lblProba.ForeColor = initial;
            lblProba.Font=font;
            lblProba.Visible=true;
        }
    }
}

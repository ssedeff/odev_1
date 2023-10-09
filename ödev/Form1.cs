using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Merhaba Dünya";
            textBox1.ForeColor = Color.AliceBlue;
            textBox1.Enabled= false;
            textBox1.Visible = true;
            textBox1.Font = new Font("castellar", 16);
        }
    }
}

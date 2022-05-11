using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 aform = new Form2();
            aform.Text="Hello world!";
            aform.Load += new EventHandler(MyForm_Load2);

            aform.Show();
        }
        private void MyForm_Load2(object sender, EventArgs e)
        {
            MessageBox.Show("Shown2");
        }

    }
}

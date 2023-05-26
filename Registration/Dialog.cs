using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Dialog : Form
    {
        int A, B;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Answer.Text == (A + B).ToString())
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
                MessageBox.Show("Ответ не верный");
                
        }

        public Dialog()
        {
            Random r = new Random();
            A = r.Next(0, 50);
            B = r.Next(0, 50);
            InitializeComponent();
            labelA.Text = A.ToString();
            labelB.Text = B.ToString();
        }
    }
}

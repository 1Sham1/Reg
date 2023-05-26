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
    public partial class MainMainForm : Form
    {
        PictureBox pictureBox;
        Form mainForm;
        public MainMainForm(Form mainForm)
        {
            
            InitializeComponent();            
            this.mainForm = mainForm;
            /*
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(500,500);
            //pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Load("floor.gif");
            pictureBox.Parent = this;*/
        }

        private void MainMainForm_Activated(object sender, EventArgs e)
        {

            mainForm.Visible = false;
        }

        private void MainMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }
    }
}

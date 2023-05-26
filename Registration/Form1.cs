using Registration.Properties;
using System.ComponentModel;
using System.Media;
using System.Reflection;

namespace Registration
{
    public partial class Form1 : Form
    {
        private const string Sound = @"Registration.good_sound.wav";

        public Form1()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream resourceStream = assembly.GetManifestResourceStream(Sound);
            SoundPlayer player = new SoundPlayer(resourceStream);
            player.PlayLooping();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            Form_enter enter = new Form_enter(this);
            enter.Show();
            this.Visible = false;
        }

        private void button_regist_Click(object sender, EventArgs e)
        {
            Form_reg reg = new Form_reg(this);
            reg.Show();
            this.Visible = false;
        }
    }
}
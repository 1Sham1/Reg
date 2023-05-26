using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Image = System.Drawing.Image;
using Timer = System.Windows.Forms.Timer;
namespace Registration
{
    public partial class Form_enter : Form
    {
        Form mainForm;
        List<Button> game;
        Timer timerReplay, timerTextrun;
        PictureBox pictureBox;
        Regex password;

        public Form_enter(Form mainForm)
        {
            password = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])\S{1,16}$");

            timerReplay = new Timer();
            timerReplay.Interval = 3000;
            timerReplay.Tick += new EventHandler(timerReplay_Tick);

            timerTextrun = new Timer();
            timerTextrun.Interval = 50;
            timerTextrun.Tick += new EventHandler(timerTextrun_Tick);
            timerTextrun.Start();

            game = new List<Button>();
            this.mainForm = mainForm;                          
            InitializeComponent();

            label_login_red.Visible = false;
            label_pass_red.Visible = false;
            button_enter1_fail.Visible = false;
            button_enter2_fail.Visible = false;
            button_enter3_complete.Visible = false;
            label_choose.Visible = false;
            label_uvy.Visible = false;

            game.Add(button_enter1_fail);
            game.Add(button_enter2_fail);
            game.Add(button_enter3_complete);
        }

        private void timerTextrun_Tick(object? sender, EventArgs e)
        {
            if (label_pass_red != null)
            {
                string text = label_pass_red.Text.Substring(1) + label_pass_red.Text[0];
                label_pass_red.Text = text;
            }
            if (label_login_red != null)
            {
                string text = label_login_red.Text.Substring(1) + label_login_red.Text[0];
                label_login_red.Text = text;
            }
        }

        void timerReplay_Tick(object? sender, EventArgs e)
        {
            button_enter1_fail.Visible = false;
            button_enter2_fail.Visible = false;
            button_enter3_complete.Visible = false;
            label_choose.Visible=false;
            enableClick();
            UnDrawKey();
            unShowPictureFail();
            button_enter.Visible = true;
            timerReplay.Stop();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            button_enter.Visible = false;
            label_choose.Visible = true;
            shuffleBtn();

        }

        void showPictureFail()
        {
            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = this.Size;
            pictureBox.Load("jokerge_uvy.gif");
            pictureBox.Parent = this;
            label_uvy.Visible = true;
        }

        void unShowPictureFail()
        {
            pictureBox.Dispose();
            label_uvy.Visible = false;
        }

        void shuffleBtn()
        {
            Random r = new Random();
            for (int i = game.Count - 1; i > 0; i--)
            {
                int k = r.Next(i + 1);
                Point value = game[k].Location;
                game[k].Location = game[i].Location;
                game[i].Location = value;
            }
            foreach (var item in game)
                item.Visible = true;
        }

        private void button_enter1_fail_Click(object? sender, EventArgs e)
        {
            DrawKey();
            disableClick();
            showPictureFail();
            timerReplay.Start();
        }

        private void button_enter2_fail_Click(object? sender, EventArgs e)
        {
            DrawKey();
            disableClick();
            showPictureFail();
            timerReplay.Start();
        }

        void disableClick()
        {
            button_enter1_fail.Click -= button_enter1_fail_Click;
            button_enter2_fail.Click -= button_enter2_fail_Click;
            button_enter3_complete.Click -= button_enter3_complete_Click;
        }

        void enableClick()
        {
            button_enter1_fail.Click += button_enter1_fail_Click;
            button_enter2_fail.Click += button_enter2_fail_Click;
            button_enter3_complete.Click += button_enter3_complete_Click;
        }

        private void button_enter3_complete_Click(object? sender, EventArgs e)
        {
            DrawKey();
            if (confirm_test())
            {
                if (checkLogAndPass())
                {
                    MainMainForm app = new MainMainForm(mainForm);
                    this.Visible = false;
                    app.Show();
                    
                }
            }
        }

        bool checkLogAndPass()
        {
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";
            mysqlCSB.Database = "PDF";
            mysqlCSB.UserID = "root";
            mysqlCSB.Password = "Orlov476qwer!";
            string querySelectLogin = @"SELECT user_password from user where login =@login";
            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;
                MySqlCommand com = new MySqlCommand(querySelectLogin, con);
                com.Parameters.AddWithValue("@login", textBox_login.Text);
                try
                {

                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {

                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                if (textBox_password.Text == dr[0].ToString())
                                {
                                    con.Close();
                                    return true;
                                }
                                else
                                {
                                    label_mes.Text = "Неверное имя пользователя или пароль";
                                    con.Close();
                                    return false;
                                }
                            }
                            else 
                            {
                                label_mes.Text = "Пользователь с таким именем не найден";
                                con.Close();
                                return false; 
                            }
                        }
                        else
                        {
                            label_mes.Text = "Пользователь с таким именем не найден";
                            con.Close();
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        bool confirm_test()
        {
            return (textBox_login.Text.Length >= 6 || textBox_login.Text.Length <= 25) &&
                   (password.IsMatch(textBox_password.Text));
        }



        void DrawKey()
        {
            Image fullsizeimage;
            using (var stream = new FileStream("key.png", FileMode.Open))
            {
                fullsizeimage = Image.FromStream(stream);
                button_enter3_complete.Image = new Bitmap(fullsizeimage, new Size(button_enter3_complete.ClientRectangle.Width, button_enter3_complete.ClientRectangle.Height));
            }
        }
        void UnDrawKey()
        {
            button_enter3_complete.Image = null;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_enter_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerTextrun.Stop();
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            if(textBox_login.Text.Length < 6 || textBox_login.Text.Length > 25)
                label_login_red.Visible= true;
            else
                label_login_red.Visible= false;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (!password.IsMatch(textBox_password.Text))
                label_pass_red.Visible = true;
            else 
                label_pass_red.Visible= false;
        }

        private void Form_enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }
    }

    
}

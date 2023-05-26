using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Timer = System.Windows.Forms.Timer;

namespace Registration
{
    public partial class Form_reg : Form
    {
        Timer timerShake, timerBanner, timerTextrun;
        int selectedIndex = -1;
        double angle = 0;
        Form mainForm;
        Random r;
        Regex login, email, password;
        public Form_reg(Form mainForm)
        {
            
            r = new Random();
            login = new Regex(@"^[a-zA-Z][a-zA-Z1-9]{7,24}");
            password = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])\S{1,16}$");
            email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            this.mainForm = mainForm;
            InitializeComponent();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Load("hmmmm.gif");
            pictureBox.Parent = this;
            timerShake = new Timer();
            timerShake.Interval = 50;
            timerShake.Tick += new EventHandler(timerShake_Tick);
            timerShake.Start();
            timerBanner = new Timer();
            timerBanner.Interval = 8000;
            timerBanner.Tick += new EventHandler(timerBanner_Tick);
            timerBanner.Start();
            label_hint_pass.BackColor = System.Drawing.Color.Transparent;
            timerTextrun = new Timer();
            timerTextrun.Interval = 50;
            timerTextrun.Tick += new EventHandler(timerTextrun_Tick);
            timerTextrun.Start();
            label_login_red.Visible= false;
            label_hint_pass.Visible= false;
            label_email_red.Visible= false;
            label_hint_pass2.Visible= false;
        }

        private void timerTextrun_Tick(object? sender, EventArgs e)
        {
            if (label_hint_pass != null)
            {
                string text = label_hint_pass.Text.Substring(1) + label_hint_pass.Text[0];
                label_hint_pass.Text = text;
            }
            if (label_login_red!= null)
            {
                string text = label_login_red.Text.Substring(1) + label_login_red.Text[0];
                label_login_red.Text = text;
            }
        }

        void timerShake_Tick(object? sender, EventArgs e)
        {
            int x1  = (int)( 10 * Math.Cos(angle));
            int x2 = (int)(7 * Math.Cos(angle));
            groupBox_Password1.Location = new Point(x1 + groupBox_Password1.Location.X,groupBox_Password1.Location.Y);
            groupBox_Password2.Location = new Point(x2 + groupBox_Password2.Location.X, groupBox_Password2.Location.Y);
            groupBox_login.Location = new Point(x1 + groupBox_login.Location.X, groupBox_login.Location.Y);
            groupBox_email.Location = new Point(x2 + groupBox_email.Location.X, groupBox_email.Location.Y) ;
            angle = angle + 0.1;
        }

        private void textBox_login_Enter(object sender, EventArgs e)
        {
            selectedIndex= 0;
        }

        private void textBox_email_Enter(object sender, EventArgs e)
        {
            selectedIndex= 1;
        }

        private void textBox_Password1_Enter(object sender, EventArgs e)
        {
            selectedIndex = 2;
        }

        private void textBox_password2_Enter(object sender, EventArgs e)
        {
            selectedIndex= 3;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            selectedIndex = r.Next(4,7);
            DialogResult result = MessageBox.Show("Вы хотите подтвердить регистрацию аккаунта?","Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                result = MessageBox.Show("Вы в этом точно уверены?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    result = MessageBox.Show("Мы отменяем подтверждение?", "Подтверждение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    { 
                        Dialog dialog = new Dialog();
                        if (dialog.ShowDialog() == DialogResult.Yes && confirm_test())
                        {

                            if (!AddNewUserInDataBase())
                                MessageBox.Show("Пользователь с таким именем уже существует");
                            else
                            {
                                MessageBox.Show("Регистрация успешно пройдена. Возврат в главное меню", "Успех", MessageBoxButtons.OK);
                                mainForm.Visible= true;
                                Close();
                            }      
                        }
                        else
                        {
                            MessageBox.Show("Допущены ошибки при вводе данных");
                        }
                    }
                }
            }
        }

        bool AddNewUserInDataBase()
        {
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";
            mysqlCSB.Database = "PDF";
            mysqlCSB.UserID = "root";
            mysqlCSB.Password = "Orlov476qwer!";
            string queryInsert = @"INSERT INTO user(profile_status, login, user_password, email) values('USER', @login, @password, @email)";
            string querySelectLogin = @"SELECT login from user";
            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;
                MySqlCommand comInsert = new MySqlCommand(queryInsert, con);
                MySqlCommand comSelect = new MySqlCommand(querySelectLogin, con);
                try
                {

                    con.Open();
                    using (MySqlDataReader dr = comSelect.ExecuteReader())
                    {

                        if (dr.HasRows) 
                        { 
                            while (dr.Read())
                            {
                                    if (textBox_login.Text == dr[0].ToString())
                                    {                                                 
                                        con.Close();
                                        return false;
                                    }
                            }
                        }
                    }
                    comInsert.Parameters.AddWithValue("login", textBox_login.Text);
                    comInsert.Parameters.AddWithValue("password", textBox_Password1.Text);
                    comInsert.Parameters.AddWithValue("email", textBox_email.Text);     
                    comInsert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                    return false;
                }
                con.Close();
                return true;
            }
        }

        bool confirm_test()
        {
            return (login.IsMatch(textBox_login.Text)) && 
                   (email.IsMatch(textBox_email.Text) || textBox_email.Text.Length <= 50) &&
                   (password.IsMatch(textBox_Password1.Text)) &&
                   (textBox_password2.Text == textBox_Password1.Text);            
        }

        private void Form_reg_FormClosed(object sender, FormClosedEventArgs e)
        {

            mainForm.Visible = true;   
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            if (!login.IsMatch( textBox_login.Text))
                label_login_red.Visible = true;
            else
                label_login_red.Visible = false;
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            
            if (!email.IsMatch(textBox_email.Text) || textBox_email.Text.Length > 50)
                label_email_red.Visible = true;
            else 
                label_email_red.Visible = false;
        }

        private void textBox_Password1_TextChanged(object sender, EventArgs e)
        {            
            if(!password.IsMatch(textBox_Password1.Text))
                label_hint_pass.Visible = true;
            else 
                label_hint_pass.Visible = false;
        }

        private void Form_reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerBanner.Stop();
            timerShake.Stop();
            timerTextrun.Stop();
        }

        private void textBox_password2_TextChanged(object sender, EventArgs e)
        {
            if(textBox_password2.Text != textBox_Password1.Text)
                label_hint_pass2.Visible = true;
            else
                label_hint_pass2.Visible= false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Close();
            
        }

        void timerBanner_Tick(object? sender, EventArgs e)
        {
            switch (selectedIndex)
            {
                case 0:createBanner("Стоит хорошо подумать над логином,\n чтобы потом не было стыдно."); break;
                case 1: if (!email.IsMatch(textBox_email.Text)) 
                    {
                        createBanner("Вы же не забыли свою почту?");
                    }
                    break;
                case 2: createBanner("Ты же не собираешься\n писать Qwerty123$ ?"); break;
                case 3: createBanner("Остался последний шаг"); break;
                case 4: createBanner("Интересный факт:\nБасенджи – единственная собака,\nкоторая не может лаять."); break;
                case 5: createBanner("Интересный факт:\nХамелеоны могут двигать глазами\nв разных направлениях одновременно."); break;
                case 6: createBanner("Интересный факт:\nСердце креветки находится в голове."); break;
                case 7: createBanner("Интересный факт:\nМухи жужжат нотой ФА."); break;
                case 8: createBanner("Интересный факт:\nПаук Тарантул может жить без пищи два года."); break;
                case 9: createBanner("Интересный факт:\nКрокодилы не могут высовывать язык."); break;
                case 10: createBanner("Интересный факт:\nВерблюд может обходиться без воды две недели."); break;
                        
                default: break;
            }
            selectedIndex = r.Next(4,10);
        }


        void createBanner(string message)
        {
            Banner banner = new Banner(message);
            banner.Location = new Point( Location.X + Size.Width / 3, Location.Y + Size.Height / 3);
            banner.Show();
        }
    }
}

namespace Registration
{
    partial class Form_enter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_enter = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_enter1_fail = new System.Windows.Forms.Button();
            this.button_enter2_fail = new System.Windows.Forms.Button();
            this.button_enter3_complete = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_choose = new System.Windows.Forms.Label();
            this.label_uvy = new System.Windows.Forms.Label();
            this.label_login_red = new System.Windows.Forms.Label();
            this.label_pass_red = new System.Windows.Forms.Label();
            this.label_mes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(56, 247);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(80, 30);
            this.button_enter.TabIndex = 0;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(231, 247);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(80, 30);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Назад";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_enter1_fail
            // 
            this.button_enter1_fail.Location = new System.Drawing.Point(56, 199);
            this.button_enter1_fail.Name = "button_enter1_fail";
            this.button_enter1_fail.Size = new System.Drawing.Size(80, 30);
            this.button_enter1_fail.TabIndex = 2;
            this.button_enter1_fail.Text = "Войти";
            this.button_enter1_fail.UseVisualStyleBackColor = true;
            this.button_enter1_fail.Click += new System.EventHandler(this.button_enter1_fail_Click);
            // 
            // button_enter2_fail
            // 
            this.button_enter2_fail.Location = new System.Drawing.Point(145, 199);
            this.button_enter2_fail.Name = "button_enter2_fail";
            this.button_enter2_fail.Size = new System.Drawing.Size(80, 30);
            this.button_enter2_fail.TabIndex = 3;
            this.button_enter2_fail.Text = "Войти";
            this.button_enter2_fail.UseVisualStyleBackColor = true;
            this.button_enter2_fail.Click += new System.EventHandler(this.button_enter2_fail_Click);
            // 
            // button_enter3_complete
            // 
            this.button_enter3_complete.Location = new System.Drawing.Point(231, 199);
            this.button_enter3_complete.Name = "button_enter3_complete";
            this.button_enter3_complete.Size = new System.Drawing.Size(80, 30);
            this.button_enter3_complete.TabIndex = 4;
            this.button_enter3_complete.Text = "Войти";
            this.button_enter3_complete.UseVisualStyleBackColor = true;
            this.button_enter3_complete.Click += new System.EventHandler(this.button_enter3_complete_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(56, 44);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(255, 23);
            this.textBox_login.TabIndex = 5;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(56, 116);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(255, 23);
            this.textBox_password.TabIndex = 6;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(56, 26);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(86, 15);
            this.label_login.TabIndex = 7;
            this.label_login.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите пароль";
            // 
            // label_choose
            // 
            this.label_choose.AutoSize = true;
            this.label_choose.Location = new System.Drawing.Point(91, 181);
            this.label_choose.Name = "label_choose";
            this.label_choose.Size = new System.Drawing.Size(201, 15);
            this.label_choose.TabIndex = 9;
            this.label_choose.Text = "Под какой кнопкой ключ от входа?";
            // 
            // label_uvy
            // 
            this.label_uvy.AutoSize = true;
            this.label_uvy.BackColor = System.Drawing.Color.Black;
            this.label_uvy.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_uvy.ForeColor = System.Drawing.Color.Red;
            this.label_uvy.Location = new System.Drawing.Point(3, 243);
            this.label_uvy.Name = "label_uvy";
            this.label_uvy.Size = new System.Drawing.Size(85, 46);
            this.label_uvy.TabIndex = 10;
            this.label_uvy.Text = "УВЫ";
            // 
            // label_login_red
            // 
            this.label_login_red.AutoSize = true;
            this.label_login_red.ForeColor = System.Drawing.Color.Red;
            this.label_login_red.Location = new System.Drawing.Point(56, 70);
            this.label_login_red.Name = "label_login_red";
            this.label_login_red.Size = new System.Drawing.Size(379, 15);
            this.label_login_red.TabIndex = 11;
            this.label_login_red.Text = "Длина от 8 до 25 символов и только латинские буквы и цифры        ";
            // 
            // label_pass_red
            // 
            this.label_pass_red.AutoSize = true;
            this.label_pass_red.ForeColor = System.Drawing.Color.Red;
            this.label_pass_red.Location = new System.Drawing.Point(56, 142);
            this.label_pass_red.Name = "label_pass_red";
            this.label_pass_red.Size = new System.Drawing.Size(1110, 15);
            this.label_pass_red.TabIndex = 12;
            this.label_pass_red.Text = "Пароль должен содержать от 8 до 50 символов, иметь хотя бы одну заглавную букву л" +
    "атинского алфавита и иметь хотя бы одну цифру и спец. символ.    ЗДЕСЬ МОГЛА БЫТ" +
    "Ь ВАША РЕКЛАМА              ";
            // 
            // label_mes
            // 
            this.label_mes.AutoSize = true;
            this.label_mes.ForeColor = System.Drawing.Color.Red;
            this.label_mes.Location = new System.Drawing.Point(56, 9);
            this.label_mes.Name = "label_mes";
            this.label_mes.Size = new System.Drawing.Size(0, 15);
            this.label_mes.TabIndex = 13;
            // 
            // Form_enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(368, 298);
            this.Controls.Add(this.label_mes);
            this.Controls.Add(this.label_pass_red);
            this.Controls.Add(this.label_login_red);
            this.Controls.Add(this.label_uvy);
            this.Controls.Add(this.label_choose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_enter3_complete);
            this.Controls.Add(this.button_enter2_fail);
            this.Controls.Add(this.button_enter1_fail);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_enter);
            this.Name = "Form_enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_enter_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_enter_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_enter;
        private Button button_cancel;
        private Button button_enter1_fail;
        private Button button_enter2_fail;
        private Button button_enter3_complete;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private Label label_login;
        private Label label2;
        private Label label_choose;
        private Label label_uvy;
        private Label label_login_red;
        private Label label_pass_red;
        private Label label_mes;
    }
}
namespace Registration
{
    partial class Form_reg
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
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox_Password1 = new System.Windows.Forms.GroupBox();
            this.label_hint_pass = new System.Windows.Forms.Label();
            this.textBox_Password1 = new System.Windows.Forms.TextBox();
            this.label_password1 = new System.Windows.Forms.Label();
            this.groupBox_Password2 = new System.Windows.Forms.GroupBox();
            this.label_hint_pass2 = new System.Windows.Forms.Label();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.label_password2 = new System.Windows.Forms.Label();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.label_login_red = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.groupBox_email = new System.Windows.Forms.GroupBox();
            this.label_email_red = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.groupBox_Password1.SuspendLayout();
            this.groupBox_Password2.SuspendLayout();
            this.groupBox_login.SuspendLayout();
            this.groupBox_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.SystemColors.Control;
            this.button_confirm.Location = new System.Drawing.Point(76, 401);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(96, 23);
            this.button_confirm.TabIndex = 0;
            this.button_confirm.Text = "Подтвердить";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(243, 401);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(96, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // groupBox_Password1
            // 
            this.groupBox_Password1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Password1.Controls.Add(this.label_hint_pass);
            this.groupBox_Password1.Controls.Add(this.textBox_Password1);
            this.groupBox_Password1.Controls.Add(this.label_password1);
            this.groupBox_Password1.Location = new System.Drawing.Point(87, 226);
            this.groupBox_Password1.Name = "groupBox_Password1";
            this.groupBox_Password1.Size = new System.Drawing.Size(233, 76);
            this.groupBox_Password1.TabIndex = 11;
            this.groupBox_Password1.TabStop = false;
            // 
            // label_hint_pass
            // 
            this.label_hint_pass.AutoSize = true;
            this.label_hint_pass.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hint_pass.ForeColor = System.Drawing.Color.Red;
            this.label_hint_pass.Location = new System.Drawing.Point(0, 60);
            this.label_hint_pass.Name = "label_hint_pass";
            this.label_hint_pass.Size = new System.Drawing.Size(1064, 13);
            this.label_hint_pass.TabIndex = 14;
            this.label_hint_pass.Text = "Пароль должен содержать от 8 до 50 символов, иметь хотя бы одну заглавную букву л" +
    "атинского алфавита и иметь хотя бы одну цифру и спец. символ.    ЗДЕСЬ МОГЛА БЫТ" +
    "Ь ВАША РЕКЛАМА              ";
            // 
            // textBox_Password1
            // 
            this.textBox_Password1.Location = new System.Drawing.Point(42, 37);
            this.textBox_Password1.Name = "textBox_Password1";
            this.textBox_Password1.Size = new System.Drawing.Size(157, 23);
            this.textBox_Password1.TabIndex = 2;
            this.textBox_Password1.TextChanged += new System.EventHandler(this.textBox_Password1_TextChanged);
            this.textBox_Password1.Enter += new System.EventHandler(this.textBox_Password1_Enter);
            // 
            // label_password1
            // 
            this.label_password1.AutoSize = true;
            this.label_password1.Location = new System.Drawing.Point(74, 19);
            this.label_password1.Name = "label_password1";
            this.label_password1.Size = new System.Drawing.Size(93, 15);
            this.label_password1.TabIndex = 3;
            this.label_password1.Text = "Введите пароль";
            // 
            // groupBox_Password2
            // 
            this.groupBox_Password2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Password2.Controls.Add(this.label_hint_pass2);
            this.groupBox_Password2.Controls.Add(this.textBox_password2);
            this.groupBox_Password2.Controls.Add(this.label_password2);
            this.groupBox_Password2.Location = new System.Drawing.Point(87, 308);
            this.groupBox_Password2.Name = "groupBox_Password2";
            this.groupBox_Password2.Size = new System.Drawing.Size(233, 83);
            this.groupBox_Password2.TabIndex = 12;
            this.groupBox_Password2.TabStop = false;
            // 
            // label_hint_pass2
            // 
            this.label_hint_pass2.AutoSize = true;
            this.label_hint_pass2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hint_pass2.ForeColor = System.Drawing.Color.Red;
            this.label_hint_pass2.Location = new System.Drawing.Point(58, 63);
            this.label_hint_pass2.Name = "label_hint_pass2";
            this.label_hint_pass2.Size = new System.Drawing.Size(124, 13);
            this.label_hint_pass2.TabIndex = 15;
            this.label_hint_pass2.Text = "Пароли не совпадают";
            // 
            // textBox_password2
            // 
            this.textBox_password2.Location = new System.Drawing.Point(42, 37);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(157, 23);
            this.textBox_password2.TabIndex = 2;
            this.textBox_password2.TextChanged += new System.EventHandler(this.textBox_password2_TextChanged);
            this.textBox_password2.Enter += new System.EventHandler(this.textBox_password2_Enter);
            // 
            // label_password2
            // 
            this.label_password2.AutoSize = true;
            this.label_password2.Location = new System.Drawing.Point(73, 19);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(109, 15);
            this.label_password2.TabIndex = 3;
            this.label_password2.Text = "Повторите пароль";
            // 
            // groupBox_login
            // 
            this.groupBox_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_login.Controls.Add(this.label_login_red);
            this.groupBox_login.Controls.Add(this.textBox_login);
            this.groupBox_login.Controls.Add(this.label_login);
            this.groupBox_login.Location = new System.Drawing.Point(87, 62);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(233, 80);
            this.groupBox_login.TabIndex = 12;
            this.groupBox_login.TabStop = false;
            // 
            // label_login_red
            // 
            this.label_login_red.AutoSize = true;
            this.label_login_red.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login_red.ForeColor = System.Drawing.Color.Red;
            this.label_login_red.Location = new System.Drawing.Point(6, 62);
            this.label_login_red.Name = "label_login_red";
            this.label_login_red.Size = new System.Drawing.Size(369, 13);
            this.label_login_red.TabIndex = 13;
            this.label_login_red.Text = "Длина от 8 до 25 символов и только латинские буквы и цифры        ";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(42, 36);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(157, 23);
            this.textBox_login.TabIndex = 2;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            this.textBox_login.Enter += new System.EventHandler(this.textBox_login_Enter);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(73, 19);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(86, 15);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Введите логин";
            // 
            // groupBox_email
            // 
            this.groupBox_email.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_email.Controls.Add(this.label_email_red);
            this.groupBox_email.Controls.Add(this.textBox_email);
            this.groupBox_email.Controls.Add(this.label_email);
            this.groupBox_email.Location = new System.Drawing.Point(87, 148);
            this.groupBox_email.Name = "groupBox_email";
            this.groupBox_email.Size = new System.Drawing.Size(233, 81);
            this.groupBox_email.TabIndex = 12;
            this.groupBox_email.TabStop = false;
            // 
            // label_email_red
            // 
            this.label_email_red.AutoSize = true;
            this.label_email_red.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_email_red.ForeColor = System.Drawing.Color.Red;
            this.label_email_red.Location = new System.Drawing.Point(42, 62);
            this.label_email_red.Name = "label_email_red";
            this.label_email_red.Size = new System.Drawing.Size(152, 13);
            this.label_email_red.TabIndex = 14;
            this.label_email_red.Text = "Почта неверного формата";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(42, 37);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(157, 23);
            this.textBox_email.TabIndex = 2;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            this.textBox_email.Enter += new System.EventHandler(this.textBox_email_Enter);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(38, 19);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(162, 15);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "Введите электронную почту";
            // 
            // Form_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(429, 471);
            this.Controls.Add(this.groupBox_email);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.groupBox_Password2);
            this.Controls.Add(this.groupBox_Password1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Name = "Form_reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_reg_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_reg_FormClosed);
            this.groupBox_Password1.ResumeLayout(false);
            this.groupBox_Password1.PerformLayout();
            this.groupBox_Password2.ResumeLayout(false);
            this.groupBox_Password2.PerformLayout();
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            this.groupBox_email.ResumeLayout(false);
            this.groupBox_email.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_confirm;
        private Button button_cancel;
        private GroupBox groupBox_Password1;
        private TextBox textBox_Password1;
        private Label label_password1;
        private GroupBox groupBox_Password2;
        private TextBox textBox_password2;
        private Label label_password2;
        private GroupBox groupBox_login;
        private TextBox textBox_login;
        private Label label_login;
        private GroupBox groupBox_email;
        private TextBox textBox_email;
        private Label label_email;
        private Label label_hint_pass;
        private Label label_login_red;
        private Label label_email_red;
        private Label label_hint_pass2;
    }
}
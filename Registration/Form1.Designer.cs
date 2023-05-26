namespace Registration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_enter = new System.Windows.Forms.Button();
            this.button_regist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_enter
            // 
            this.button_enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_enter.BackColor = System.Drawing.Color.Blue;
            this.button_enter.Location = new System.Drawing.Point(227, 330);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(172, 74);
            this.button_enter.TabIndex = 0;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_regist
            // 
            this.button_regist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_regist.BackColor = System.Drawing.Color.Red;
            this.button_regist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_regist.Location = new System.Drawing.Point(516, 330);
            this.button_regist.Name = "button_regist";
            this.button_regist.Size = new System.Drawing.Size(172, 74);
            this.button_regist.TabIndex = 1;
            this.button_regist.Text = "Регистрация";
            this.button_regist.UseVisualStyleBackColor = false;
            this.button_regist.Click += new System.EventHandler(this.button_regist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Registration.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 532);
            this.Controls.Add(this.button_regist);
            this.Controls.Add(this.button_enter);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно приветствия";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_enter;
        private Button button_regist;
    }
}
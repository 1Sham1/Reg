namespace Registration
{
    partial class Banner
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
            this.label_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_message.Location = new System.Drawing.Point(12, 9);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(108, 25);
            this.label_message.TabIndex = 0;
            this.label_message.Text = "Сообщение";
            // 
            // Banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 248);
            this.Controls.Add(this.label_message);
            this.Name = "Banner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ВАЖНОЕ УВЕДОМЛЕНИЕ!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_message;
    }
}
namespace Client
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
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxReceivingData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(12, 12);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(326, 23);
            this.textBoxSend.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(344, 11);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxReceivingData
            // 
            this.textBoxReceivingData.Location = new System.Drawing.Point(12, 52);
            this.textBoxReceivingData.Multiline = true;
            this.textBoxReceivingData.Name = "textBoxReceivingData";
            this.textBoxReceivingData.Size = new System.Drawing.Size(407, 204);
            this.textBoxReceivingData.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 268);
            this.Controls.Add(this.textBoxReceivingData);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSend);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSend;
        private Button buttonSend;
        private TextBox textBoxReceivingData;
    }
}
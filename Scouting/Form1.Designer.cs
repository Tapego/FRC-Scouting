namespace Scouting
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.RequestTBA = new System.Windows.Forms.Button();
            this.EventCode = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "The Blue Alliance";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RequestTBA
            // 
            this.RequestTBA.Location = new System.Drawing.Point(258, 28);
            this.RequestTBA.Name = "RequestTBA";
            this.RequestTBA.Size = new System.Drawing.Size(120, 28);
            this.RequestTBA.TabIndex = 1;
            this.RequestTBA.Text = "Get TBA Statistics";
            this.RequestTBA.UseVisualStyleBackColor = true;
            this.RequestTBA.Click += new System.EventHandler(this.RequestTBA_click);
            // 
            // EventCode
            // 
            this.EventCode.Location = new System.Drawing.Point(188, 33);
            this.EventCode.Name = "EventCode";
            this.EventCode.Size = new System.Drawing.Size(64, 20);
            this.EventCode.TabIndex = 3;
            this.EventCode.Text = "sc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(114, 33);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(68, 21);
            this.Year.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 279);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EventCode);
            this.Controls.Add(this.RequestTBA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RequestTBA;
        private System.Windows.Forms.TextBox EventCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Year;
    }
}


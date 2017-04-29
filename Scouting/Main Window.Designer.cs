namespace Scouting
{
    partial class Main_Window
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
            this.EventScout_btn = new System.Windows.Forms.Button();
            this.TeamScout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventScout_btn
            // 
            this.EventScout_btn.Location = new System.Drawing.Point(12, 12);
            this.EventScout_btn.Name = "EventScout_btn";
            this.EventScout_btn.Size = new System.Drawing.Size(101, 28);
            this.EventScout_btn.TabIndex = 0;
            this.EventScout_btn.Text = "Event Scouting";
            this.EventScout_btn.UseVisualStyleBackColor = true;
            this.EventScout_btn.Click += new System.EventHandler(this.EventScout_btn_Click);
            // 
            // TeamScout_btn
            // 
            this.TeamScout_btn.Location = new System.Drawing.Point(12, 57);
            this.TeamScout_btn.Name = "TeamScout_btn";
            this.TeamScout_btn.Size = new System.Drawing.Size(101, 28);
            this.TeamScout_btn.TabIndex = 1;
            this.TeamScout_btn.Text = "Team Scouting";
            this.TeamScout_btn.UseVisualStyleBackColor = true;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 546);
            this.Controls.Add(this.TeamScout_btn);
            this.Controls.Add(this.EventScout_btn);
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EventScout_btn;
        private System.Windows.Forms.Button TeamScout_btn;
    }
}
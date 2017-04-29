namespace Scouting
{
    partial class EventView
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
            this.RequestTBA = new System.Windows.Forms.Button();
            this.EventCode = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Matchview_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rankings_lbl = new System.Windows.Forms.Label();
            this.CurrentMatch_lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestTBA
            // 
            this.RequestTBA.Location = new System.Drawing.Point(153, 12);
            this.RequestTBA.Name = "RequestTBA";
            this.RequestTBA.Size = new System.Drawing.Size(120, 28);
            this.RequestTBA.TabIndex = 1;
            this.RequestTBA.Text = "Get TBA Statistics";
            this.RequestTBA.UseVisualStyleBackColor = true;
            this.RequestTBA.Click += new System.EventHandler(this.RequestTBA_click);
            // 
            // EventCode
            // 
            this.EventCode.Location = new System.Drawing.Point(83, 17);
            this.EventCode.Name = "EventCode";
            this.EventCode.Size = new System.Drawing.Size(64, 20);
            this.EventCode.TabIndex = 3;
            this.EventCode.Text = "sc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(9, 17);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(68, 21);
            this.Year.TabIndex = 5;
            // 
            // Matchview_btn
            // 
            this.Matchview_btn.Location = new System.Drawing.Point(335, 405);
            this.Matchview_btn.Name = "Matchview_btn";
            this.Matchview_btn.Size = new System.Drawing.Size(97, 26);
            this.Matchview_btn.TabIndex = 6;
            this.Matchview_btn.Text = "Match View";
            this.Matchview_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Match View";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 382);
            this.dataGridView1.TabIndex = 8;
            // 
            // Rankings_lbl
            // 
            this.Rankings_lbl.AutoSize = true;
            this.Rankings_lbl.Location = new System.Drawing.Point(292, 1);
            this.Rankings_lbl.Name = "Rankings_lbl";
            this.Rankings_lbl.Size = new System.Drawing.Size(52, 13);
            this.Rankings_lbl.TabIndex = 9;
            this.Rankings_lbl.Text = "Rankings";
            // 
            // CurrentMatch_lbl
            // 
            this.CurrentMatch_lbl.AutoSize = true;
            this.CurrentMatch_lbl.Location = new System.Drawing.Point(12, 127);
            this.CurrentMatch_lbl.Name = "CurrentMatch_lbl";
            this.CurrentMatch_lbl.Size = new System.Drawing.Size(74, 13);
            this.CurrentMatch_lbl.TabIndex = 10;
            this.CurrentMatch_lbl.Text = "Current Match";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 100);
            this.button2.TabIndex = 11;
            this.button2.Text = "I\'m confused";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 443);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CurrentMatch_lbl);
            this.Controls.Add(this.Rankings_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Matchview_btn);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EventCode);
            this.Controls.Add(this.RequestTBA);
            this.Name = "EventView";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RequestTBA;
        private System.Windows.Forms.TextBox EventCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.Button Matchview_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Rankings_lbl;
        private System.Windows.Forms.Label CurrentMatch_lbl;
        private System.Windows.Forms.Button button2;
    }
}


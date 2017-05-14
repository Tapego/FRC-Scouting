namespace Scouting
{
    partial class AddCategory
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
            this.Name_txtbox = new System.Windows.Forms.TextBox();
            this.Type_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Categories = new System.Windows.Forms.DataGridView();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_txtbox
            // 
            this.Name_txtbox.Location = new System.Drawing.Point(181, 39);
            this.Name_txtbox.Name = "Name_txtbox";
            this.Name_txtbox.Size = new System.Drawing.Size(137, 20);
            this.Name_txtbox.TabIndex = 0;
            // 
            // Type_combobox
            // 
            this.Type_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_combobox.FormattingEnabled = true;
            this.Type_combobox.Items.AddRange(new object[] {
            "Integer",
            "Double",
            "Text"});
            this.Type_combobox.Location = new System.Drawing.Point(324, 38);
            this.Type_combobox.Name = "Type_combobox";
            this.Type_combobox.Size = new System.Drawing.Size(121, 21);
            this.Type_combobox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Categories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Remove_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Add_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Type_combobox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Name_txtbox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(843, 511);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.TabIndex = 4;
            // 
            // Categories
            // 
            this.Categories.AllowUserToAddRows = false;
            this.Categories.AllowUserToDeleteRows = false;
            this.Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Categories.Location = new System.Drawing.Point(0, 0);
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            this.Categories.Size = new System.Drawing.Size(843, 436);
            this.Categories.TabIndex = 0;
            // 
            // Remove_btn
            // 
            this.Remove_btn.Location = new System.Drawing.Point(512, 36);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(120, 23);
            this.Remove_btn.TabIndex = 5;
            this.Remove_btn.Text = "Remove Selected";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(451, 36);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(55, 23);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Name_txtbox;
        private System.Windows.Forms.ComboBox Type_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView Categories;
    }
}
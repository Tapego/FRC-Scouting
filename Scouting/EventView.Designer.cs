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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RequestTBA = new System.Windows.Forms.Button();
            this.EventCode = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.RankingsGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NewEntry_btn = new System.Windows.Forms.Button();
            this.AddScoutingColumn_btn = new System.Windows.Forms.Button();
            this.TabView = new System.Windows.Forms.TabControl();
            this.RankingsTab = new System.Windows.Forms.TabPage();
            this.MatchesTab = new System.Windows.Forms.TabPage();
            this.MatchesGridView = new System.Windows.Forms.DataGridView();
            this.ScoutingTab = new System.Windows.Forms.TabPage();
            this.ScoutingView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RankingsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabView.SuspendLayout();
            this.RankingsTab.SuspendLayout();
            this.MatchesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatchesGridView)).BeginInit();
            this.ScoutingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoutingView)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestTBA
            // 
            this.RequestTBA.Location = new System.Drawing.Point(12, 43);
            this.RequestTBA.Name = "RequestTBA";
            this.RequestTBA.Size = new System.Drawing.Size(148, 28);
            this.RequestTBA.TabIndex = 1;
            this.RequestTBA.Text = "Get TBA Statistics";
            this.RequestTBA.UseVisualStyleBackColor = true;
            this.RequestTBA.Click += new System.EventHandler(this.RequestTBA_click);
            // 
            // EventCode
            // 
            this.EventCode.Location = new System.Drawing.Point(96, 17);
            this.EventCode.Name = "EventCode";
            this.EventCode.Size = new System.Drawing.Size(64, 20);
            this.EventCode.TabIndex = 3;
            this.EventCode.Text = "ausp";
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(12, 17);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(78, 21);
            this.Year.TabIndex = 5;
            // 
            // RankingsGridView
            // 
            this.RankingsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RankingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RankingsGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.RankingsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankingsGridView.Location = new System.Drawing.Point(3, 3);
            this.RankingsGridView.Name = "RankingsGridView";
            this.RankingsGridView.Size = new System.Drawing.Size(764, 411);
            this.RankingsGridView.TabIndex = 8;
            this.RankingsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RankingsGridView_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 82);
            this.button2.TabIndex = 11;
            this.button2.Text = "I\'m confused";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NewEntry_btn);
            this.splitContainer1.Panel1.Controls.Add(this.AddScoutingColumn_btn);
            this.splitContainer1.Panel1.Controls.Add(this.RequestTBA);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.EventCode);
            this.splitContainer1.Panel1.Controls.Add(this.Year);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabView);
            this.splitContainer1.Size = new System.Drawing.Size(955, 443);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 12;
            // 
            // NewEntry_btn
            // 
            this.NewEntry_btn.Location = new System.Drawing.Point(12, 291);
            this.NewEntry_btn.Name = "NewEntry_btn";
            this.NewEntry_btn.Size = new System.Drawing.Size(148, 23);
            this.NewEntry_btn.TabIndex = 13;
            this.NewEntry_btn.Text = "New Entry";
            this.NewEntry_btn.UseVisualStyleBackColor = true;
            this.NewEntry_btn.Click += new System.EventHandler(this.NewEntry_btn_Click);
            // 
            // AddScoutingColumn_btn
            // 
            this.AddScoutingColumn_btn.Location = new System.Drawing.Point(12, 320);
            this.AddScoutingColumn_btn.Name = "AddScoutingColumn_btn";
            this.AddScoutingColumn_btn.Size = new System.Drawing.Size(148, 23);
            this.AddScoutingColumn_btn.TabIndex = 12;
            this.AddScoutingColumn_btn.Text = "Add Scouting Column";
            this.AddScoutingColumn_btn.UseVisualStyleBackColor = true;
            this.AddScoutingColumn_btn.Click += new System.EventHandler(this.AddScoutingColumn_btn_Click);
            // 
            // TabView
            // 
            this.TabView.Controls.Add(this.RankingsTab);
            this.TabView.Controls.Add(this.MatchesTab);
            this.TabView.Controls.Add(this.ScoutingTab);
            this.TabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabView.Location = new System.Drawing.Point(0, 0);
            this.TabView.Name = "TabView";
            this.TabView.SelectedIndex = 0;
            this.TabView.Size = new System.Drawing.Size(778, 443);
            this.TabView.TabIndex = 12;
            // 
            // RankingsTab
            // 
            this.RankingsTab.Controls.Add(this.RankingsGridView);
            this.RankingsTab.Location = new System.Drawing.Point(4, 22);
            this.RankingsTab.Name = "RankingsTab";
            this.RankingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.RankingsTab.Size = new System.Drawing.Size(770, 417);
            this.RankingsTab.TabIndex = 0;
            this.RankingsTab.Text = "Rankings";
            this.RankingsTab.UseVisualStyleBackColor = true;
            // 
            // MatchesTab
            // 
            this.MatchesTab.Controls.Add(this.MatchesGridView);
            this.MatchesTab.Location = new System.Drawing.Point(4, 22);
            this.MatchesTab.Name = "MatchesTab";
            this.MatchesTab.Padding = new System.Windows.Forms.Padding(3);
            this.MatchesTab.Size = new System.Drawing.Size(770, 417);
            this.MatchesTab.TabIndex = 1;
            this.MatchesTab.Text = "Matches";
            this.MatchesTab.UseVisualStyleBackColor = true;
            // 
            // MatchesGridView
            // 
            this.MatchesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatchesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatchesGridView.Location = new System.Drawing.Point(3, 3);
            this.MatchesGridView.Name = "MatchesGridView";
            this.MatchesGridView.Size = new System.Drawing.Size(764, 411);
            this.MatchesGridView.TabIndex = 9;
            // 
            // ScoutingTab
            // 
            this.ScoutingTab.Controls.Add(this.ScoutingView);
            this.ScoutingTab.Location = new System.Drawing.Point(4, 22);
            this.ScoutingTab.Name = "ScoutingTab";
            this.ScoutingTab.Size = new System.Drawing.Size(770, 417);
            this.ScoutingTab.TabIndex = 2;
            this.ScoutingTab.Text = "Scouting";
            this.ScoutingTab.UseVisualStyleBackColor = true;
            // 
            // ScoutingView
            // 
            this.ScoutingView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ScoutingView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoutingView.Location = new System.Drawing.Point(0, 0);
            this.ScoutingView.Name = "ScoutingView";
            this.ScoutingView.Size = new System.Drawing.Size(770, 417);
            this.ScoutingView.TabIndex = 10;
            this.ScoutingView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScoutingView_CellEndEdit);
            this.ScoutingView.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ScoutingView_NewRowNeeded);
            this.ScoutingView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ScoutingView_UserDeletingRow);
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 443);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EventView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RankingsGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabView.ResumeLayout(false);
            this.RankingsTab.ResumeLayout(false);
            this.MatchesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatchesGridView)).EndInit();
            this.ScoutingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScoutingView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RequestTBA;
        private System.Windows.Forms.TextBox EventCode;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.DataGridView RankingsGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl TabView;
        private System.Windows.Forms.TabPage RankingsTab;
        private System.Windows.Forms.TabPage MatchesTab;
        private System.Windows.Forms.DataGridView MatchesGridView;
        private System.Windows.Forms.TabPage ScoutingTab;
        private System.Windows.Forms.DataGridView ScoutingView;
        private System.Windows.Forms.Button AddScoutingColumn_btn;
        private System.Windows.Forms.Button NewEntry_btn;
    }
}


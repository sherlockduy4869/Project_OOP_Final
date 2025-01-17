﻿namespace Project_OOP_Final
{
    partial class ClubTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClubTask));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvClubTask = new System.Windows.Forms.DataGridView();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddTask = new Project_OOP_Final.Button_Designø.RJButton();
            this.btnRemoveTask = new Project_OOP_Final.Button_Designø.RJButton();
            this.btnRedo = new Project_OOP_Final.Button_Designø.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClubTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(517, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "CLUB MEMBER TASK";
            // 
            // dtgvClubTask
            // 
            this.dtgvClubTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvClubTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvClubTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClubTask.Location = new System.Drawing.Point(12, 262);
            this.dtgvClubTask.Name = "dtgvClubTask";
            this.dtgvClubTask.RowHeadersWidth = 82;
            this.dtgvClubTask.RowTemplate.Height = 41;
            this.dtgvClubTask.Size = new System.Drawing.Size(1421, 480);
            this.dtgvClubTask.TabIndex = 4;
            this.dtgvClubTask.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvClubTask_CellFormatting);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSearch.Location = new System.Drawing.Point(376, 193);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(680, 44);
            this.txbSearch.TabIndex = 12;
            this.txbSearch.Text = "Search...";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1062, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1355, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 84);
            this.btnExit.TabIndex = 53;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddTask.BorderRadius = 40;
            this.btnAddTask.BorderSize = 0;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTask.Image")));
            this.btnAddTask.Location = new System.Drawing.Point(320, 837);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnAddTask.Size = new System.Drawing.Size(231, 191);
            this.btnAddTask.TabIndex = 54;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTask.TextColor = System.Drawing.Color.White;
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnRemoveTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnRemoveTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveTask.BorderRadius = 40;
            this.btnRemoveTask.BorderSize = 0;
            this.btnRemoveTask.FlatAppearance.BorderSize = 0;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRemoveTask.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTask.Image")));
            this.btnRemoveTask.Location = new System.Drawing.Point(620, 837);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnRemoveTask.Size = new System.Drawing.Size(231, 191);
            this.btnRemoveTask.TabIndex = 55;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveTask.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRemoveTask.UseVisualStyleBackColor = false;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnRedo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnRedo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRedo.BorderRadius = 40;
            this.btnRedo.BorderSize = 0;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Arial Narrow", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRedo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.Location = new System.Drawing.Point(920, 837);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnRedo.Size = new System.Drawing.Size(231, 191);
            this.btnRedo.TabIndex = 56;
            this.btnRedo.Text = "Re-Do";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRedo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // ClubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 1029);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvClubTask);
            this.Name = "ClubTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubTask";
            this.Load += new System.EventHandler(this.ClubTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClubTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView dtgvClubTask;
        private Button btnAdjust;
        private TextBox txbSearch;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button_Designø.RJButton btnAddTask;
        private Button_Designø.RJButton btnRemoveTask;
        private Button_Designø.RJButton btnRedo;
    }
}
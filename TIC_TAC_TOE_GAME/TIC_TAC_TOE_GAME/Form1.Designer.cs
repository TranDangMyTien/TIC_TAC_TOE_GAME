﻿namespace TIC_TAC_TOE_GAME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.b1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.b5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b9, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 911);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.b1.FlatAppearance.BorderSize = 5;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(3, 3);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(320, 297);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_click);
            // 
            // b2
            // 
            this.b2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b2.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.b2.FlatAppearance.BorderSize = 5;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(329, 3);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(320, 297);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_click);
            // 
            // b3
            // 
            this.b3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b3.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.b3.FlatAppearance.BorderSize = 5;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(655, 3);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(320, 297);
            this.b3.TabIndex = 1;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_click);
            // 
            // b4
            // 
            this.b4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b4.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.b4.FlatAppearance.BorderSize = 5;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b4.Location = new System.Drawing.Point(3, 306);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(320, 297);
            this.b4.TabIndex = 1;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button_click);
            // 
            // b5
            // 
            this.b5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b5.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.b5.FlatAppearance.BorderSize = 5;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b5.Location = new System.Drawing.Point(329, 306);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(320, 297);
            this.b5.TabIndex = 1;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button_click);
            // 
            // b6
            // 
            this.b6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b6.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.b6.FlatAppearance.BorderSize = 5;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b6.Location = new System.Drawing.Point(655, 306);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(320, 297);
            this.b6.TabIndex = 1;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button_click);
            // 
            // b7
            // 
            this.b7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b7.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.b7.FlatAppearance.BorderSize = 5;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b7.Location = new System.Drawing.Point(3, 609);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(320, 299);
            this.b7.TabIndex = 1;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button_click);
            // 
            // b8
            // 
            this.b8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b8.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.b8.FlatAppearance.BorderSize = 5;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b8.Location = new System.Drawing.Point(329, 609);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(320, 299);
            this.b8.TabIndex = 1;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button_click);
            // 
            // b9
            // 
            this.b9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b9.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.b9.FlatAppearance.BorderSize = 5;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b9.Location = new System.Drawing.Point(655, 609);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(320, 299);
            this.b9.TabIndex = 1;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(500, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic tac toe game";
            this.Click += new System.EventHandler(this.button_click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
    }
}
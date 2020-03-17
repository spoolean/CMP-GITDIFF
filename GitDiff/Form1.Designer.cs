using System;

namespace Minimalist_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MinMaxClose = new System.Windows.Forms.Panel();
            this.minimise = new System.Windows.Forms.Button();
            this.maximise = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.lblDifferent = new System.Windows.Forms.Label();
            this.lblSame = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.File2Drop = new System.Windows.Forms.ComboBox();
            this.File1Drop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MinMaxClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(300, 100);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MinMaxClose);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseMove);
            this.splitContainer1.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseUp);
            this.splitContainer1.Panel1MinSize = 27;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblDifferent);
            this.splitContainer1.Panel2.Controls.Add(this.lblSame);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.File2Drop);
            this.splitContainer1.Panel2.Controls.Add(this.File1Drop);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(408, 336);
            this.splitContainer1.SplitterDistance = 27;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // MinMaxClose
            // 
            this.MinMaxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinMaxClose.Controls.Add(this.minimise);
            this.MinMaxClose.Controls.Add(this.maximise);
            this.MinMaxClose.Controls.Add(this.close);
            this.MinMaxClose.Location = new System.Drawing.Point(302, 0);
            this.MinMaxClose.Margin = new System.Windows.Forms.Padding(0);
            this.MinMaxClose.MaximumSize = new System.Drawing.Size(106, 27);
            this.MinMaxClose.MinimumSize = new System.Drawing.Size(106, 27);
            this.MinMaxClose.Name = "MinMaxClose";
            this.MinMaxClose.Size = new System.Drawing.Size(106, 27);
            this.MinMaxClose.TabIndex = 1;
            // 
            // minimise
            // 
            this.minimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.minimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimise.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.minimise.FlatAppearance.BorderSize = 0;
            this.minimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimise.Location = new System.Drawing.Point(1, 0);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(35, 27);
            this.minimise.TabIndex = 5;
            this.minimise.Text = "—";
            this.minimise.UseVisualStyleBackColor = false;
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // maximise
            // 
            this.maximise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.maximise.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximise.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.maximise.FlatAppearance.BorderSize = 0;
            this.maximise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.maximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximise.Location = new System.Drawing.Point(36, 0);
            this.maximise.Name = "maximise";
            this.maximise.Size = new System.Drawing.Size(35, 27);
            this.maximise.TabIndex = 4;
            this.maximise.Text = "᏿";
            this.maximise.UseVisualStyleBackColor = false;
            this.maximise.Click += new System.EventHandler(this.maximise_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.close.Location = new System.Drawing.Point(71, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 27);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lblDifferent
            // 
            this.lblDifferent.AutoSize = true;
            this.lblDifferent.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDifferent.Location = new System.Drawing.Point(105, 211);
            this.lblDifferent.Name = "lblDifferent";
            this.lblDifferent.Size = new System.Drawing.Size(183, 19);
            this.lblDifferent.TabIndex = 6;
            this.lblDifferent.Text = "These Files Are Different";
            // 
            // lblSame
            // 
            this.lblSame.AutoSize = true;
            this.lblSame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSame.Location = new System.Drawing.Point(73, 211);
            this.lblSame.Name = "lblSame";
            this.lblSame.Size = new System.Drawing.Size(247, 19);
            this.lblSame.TabIndex = 5;
            this.lblSame.Text = "These Files Are Exactly The Same";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(119, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(206, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "File 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "File 1";
            // 
            // File2Drop
            // 
            this.File2Drop.FormattingEnabled = true;
            this.File2Drop.Items.AddRange(new object[] {
            "GitRepositories_1a.txt",
            "GitRepositories_1b.txt",
            "GitRepositories_2a.txt",
            "GitRepositories_2b.txt",
            "GitRepositories_3a.txt",
            "GitRepositories_3b.txt"});
            this.File2Drop.Location = new System.Drawing.Point(210, 52);
            this.File2Drop.Name = "File2Drop";
            this.File2Drop.Size = new System.Drawing.Size(184, 27);
            this.File2Drop.TabIndex = 1;

            // 
            // File1Drop
            // 
            this.File1Drop.FormattingEnabled = true;
            this.File1Drop.Items.AddRange(new object[] {
            "GitRepositories_1a.txt",
            "GitRepositories_1b.txt",
            "GitRepositories_2a.txt",
            "GitRepositories_2b.txt",
            "GitRepositories_3a.txt",
            "GitRepositories_3b.txt"});
            this.File1Drop.Location = new System.Drawing.Point(12, 52);
            this.File1Drop.Name = "File1Drop";
            this.File1Drop.Size = new System.Drawing.Size(178, 27);
            this.File1Drop.TabIndex = 0;
            this.File1Drop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(408, 336);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MinMaxClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void splitContainer1_MouseDown(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel MinMaxClose;
        private System.Windows.Forms.Button minimise;
        private System.Windows.Forms.Button maximise;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox File2Drop;
        private System.Windows.Forms.ComboBox File1Drop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDifferent;
        private System.Windows.Forms.Label lblSame;
    }
}


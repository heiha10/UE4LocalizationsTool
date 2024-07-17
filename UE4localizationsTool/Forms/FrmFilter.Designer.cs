﻿namespace UE4localizationsTool
{
    partial class FrmFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilter));
            this.button1 = new System.Windows.Forms.Button();
            this.列表框1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.ClearList = new System.Windows.Forms.Button();
            this.matchcase = new System.Windows.Forms.CheckBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.regularexpression = new System.Windows.Forms.CheckBox();
            this.reversemode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(261, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "应用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 列表框1
            // 
            this.列表框1.FormattingEnabled = true;
            this.列表框1.ItemHeight = 12;
            this.列表框1.Location = new System.Drawing.Point(12, 23);
            this.列表框1.Name = "列表框1";
            this.列表框1.ScrollAlwaysVisible = true;
            this.列表框1.Size = new System.Drawing.Size(172, 184);
            this.列表框1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "筛选值：";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(228, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "输入：";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Location = new System.Drawing.Point(441, 21);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 21);
            this.Add.TabIndex = 6;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSelected.Location = new System.Drawing.Point(441, 48);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(113, 21);
            this.RemoveSelected.TabIndex = 7;
            this.RemoveSelected.Text = "移除选择";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // ClearList
            // 
            this.ClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearList.Location = new System.Drawing.Point(441, 75);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(113, 21);
            this.ClearList.TabIndex = 8;
            this.ClearList.Text = "清空列表";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // matchcase
            // 
            this.matchcase.AutoSize = true;
            this.matchcase.Location = new System.Drawing.Point(228, 54);
            this.matchcase.Name = "matchcase";
            this.matchcase.Size = new System.Drawing.Size(72, 16);
            this.matchcase.TabIndex = 9;
            this.matchcase.Text = "匹配模式";
            this.matchcase.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Location = new System.Drawing.Point(441, 110);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(113, 23);
            this.Close.TabIndex = 10;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // regularexpression
            // 
            this.regularexpression.AutoSize = true;
            this.regularexpression.Location = new System.Drawing.Point(228, 75);
            this.regularexpression.Name = "regularexpression";
            this.regularexpression.Size = new System.Drawing.Size(84, 16);
            this.regularexpression.TabIndex = 11;
            this.regularexpression.Text = "正则表达式";
            this.regularexpression.UseVisualStyleBackColor = true;
            this.regularexpression.CheckedChanged += new System.EventHandler(this.regularexpression_CheckedChanged);
            // 
            // reversemode
            // 
            this.reversemode.AutoSize = true;
            this.reversemode.Location = new System.Drawing.Point(228, 95);
            this.reversemode.Name = "reversemode";
            this.reversemode.Size = new System.Drawing.Size(72, 16);
            this.reversemode.TabIndex = 12;
            this.reversemode.Text = "排除模式";
            this.reversemode.UseVisualStyleBackColor = true;
            // 
            // FrmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.reversemode);
            this.Controls.Add(this.regularexpression);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.matchcase);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.列表框1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 280);
            this.Name = "FrmFilter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "筛选";
            this.Load += new System.EventHandler(this.FrmFilter_Load);
            this.ColumnPanel.ResumeLayout(false);
            this.ColumnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox 列表框1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.CheckBox matchcase;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.CheckBox regularexpression;
        private System.Windows.Forms.CheckBox reversemode;
    }
}
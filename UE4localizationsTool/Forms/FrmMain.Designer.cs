﻿using System;
using System.Windows.Forms;
using UE4localizationsTool.Controls;

namespace UE4localizationsTool
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAllTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Checkforupdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Method2 = new System.Windows.Forms.ToolStripMenuItem();
            this.UseFixedSize = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DataCount = new System.Windows.Forms.ToolStripLabel();
            this.locresOprationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeLocresFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeUassetFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StateLabel = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new NDataGridView();
            this.TextName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new UE4localizationsTool.Controls.SearchBox();
            this.StatusBlock = new System.Windows.Forms.Panel();
            this.StatusText = new System.Windows.Forms.Label();
            this.StatusTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StatusBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.DataCount,
            this.locresOprationsToolStripMenuItem,
            this.StateLabel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFile.Size = new System.Drawing.Size(147, 22);
            this.OpenFile.Text = "打开";
            this.OpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllTextToolStripMenuItem,
            this.importAllTextToolStripMenuItem,
            this.toolStripSeparator1,
            this.find,
            this.replaceToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.clearFilterToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.toolStripSeparator2,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.toolStripSeparator3,
            this.fontToolStripMenuItem,
            this.rightToLeftToolStripMenuItem,
            this.darkModeToolStripMenuItem,
            this.Checkforupdates,
            this.toolStripSeparator4,
            this.Method2,
            this.UseFixedSize});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.editToolStripMenuItem.Text = "工具";
            // 
            // exportAllTextToolStripMenuItem
            // 
            this.exportAllTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noNamesToolStripMenuItem,
            this.withNamesToolStripMenuItem,
            this.csvFileToolStripMenuItem});
            this.exportAllTextToolStripMenuItem.Enabled = false;
            this.exportAllTextToolStripMenuItem.Name = "exportAllTextToolStripMenuItem";
            this.exportAllTextToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.exportAllTextToolStripMenuItem.Text = "导出所有文本";
            // 
            // noNamesToolStripMenuItem
            // 
            this.noNamesToolStripMenuItem.Enabled = false;
            this.noNamesToolStripMenuItem.Name = "noNamesToolStripMenuItem";
            this.noNamesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.noNamesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noNamesToolStripMenuItem.Text = "无名称";
            this.noNamesToolStripMenuItem.Click += new System.EventHandler(this.noNamesToolStripMenuItem_Click);
            // 
            // withNamesToolStripMenuItem
            // 
            this.withNamesToolStripMenuItem.Enabled = false;
            this.withNamesToolStripMenuItem.Name = "withNamesToolStripMenuItem";
            this.withNamesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.withNamesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.withNamesToolStripMenuItem.Text = "带名称";
            this.withNamesToolStripMenuItem.Click += new System.EventHandler(this.withNamesToolStripMenuItem_Click);
            // 
            // csvFileToolStripMenuItem
            // 
            this.csvFileToolStripMenuItem.Name = "csvFileToolStripMenuItem";
            this.csvFileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.csvFileToolStripMenuItem.Text = "CSV 文件";
            this.csvFileToolStripMenuItem.Click += new System.EventHandler(this.csvFileToolStripMenuItem_Click);
            // 
            // importAllTextToolStripMenuItem
            // 
            this.importAllTextToolStripMenuItem.Enabled = false;
            this.importAllTextToolStripMenuItem.Name = "importAllTextToolStripMenuItem";
            this.importAllTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importAllTextToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.importAllTextToolStripMenuItem.Text = "导入所有文本";
            this.importAllTextToolStripMenuItem.Click += new System.EventHandler(this.importAllTextToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.find.Size = new System.Drawing.Size(228, 22);
            this.find.Text = "查找";
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.replaceToolStripMenuItem.Text = "替换";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Enabled = false;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.filterToolStripMenuItem.Text = "筛选";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // clearFilterToolStripMenuItem
            // 
            this.clearFilterToolStripMenuItem.Enabled = false;
            this.clearFilterToolStripMenuItem.Name = "clearFilterToolStripMenuItem";
            this.clearFilterToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.clearFilterToolStripMenuItem.Text = "清除筛选";
            this.clearFilterToolStripMenuItem.Visible = false;
            this.clearFilterToolStripMenuItem.Click += new System.EventHandler(this.clearFilterToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.valueToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.sortToolStripMenuItem.Text = "排序";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.nameToolStripMenuItem.Text = "名称";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ascendingToolStripMenuItem.Text = "升序";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.descendingToolStripMenuItem.Text = "降序";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // valueToolStripMenuItem
            // 
            this.valueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem1,
            this.descendingToolStripMenuItem1});
            this.valueToolStripMenuItem.Name = "valueToolStripMenuItem";
            this.valueToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.valueToolStripMenuItem.Text = "值";
            this.valueToolStripMenuItem.Click += new System.EventHandler(this.valueToolStripMenuItem_Click);
            // 
            // ascendingToolStripMenuItem1
            // 
            this.ascendingToolStripMenuItem1.Name = "ascendingToolStripMenuItem1";
            this.ascendingToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.ascendingToolStripMenuItem1.Text = "升序";
            this.ascendingToolStripMenuItem1.Click += new System.EventHandler(this.ascendingToolStripMenuItem1_Click);
            // 
            // descendingToolStripMenuItem1
            // 
            this.descendingToolStripMenuItem1.Name = "descendingToolStripMenuItem1";
            this.descendingToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.descendingToolStripMenuItem1.Text = "降序";
            this.descendingToolStripMenuItem1.Click += new System.EventHandler(this.descendingToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.undoToolStripMenuItem.Text = "撤销";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+Z/Ctrl+Y";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.redoToolStripMenuItem.Text = "重做";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.copyToolStripMenuItem1.Text = "复制";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.pasteToolStripMenuItem1.Text = "粘贴";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.fontToolStripMenuItem.Text = "字体";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // rightToLeftToolStripMenuItem
            // 
            this.rightToLeftToolStripMenuItem.Name = "rightToLeftToolStripMenuItem";
            this.rightToLeftToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.rightToLeftToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.rightToLeftToolStripMenuItem.Text = "从右到左 (开/关)";
            this.rightToLeftToolStripMenuItem.Click += new System.EventHandler(this.rightToLeftToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.CheckOnClick = true;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.darkModeToolStripMenuItem.Text = "深色模式";
            this.darkModeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.darkModeToolStripMenuItem_CheckedChanged);
            // 
            // Checkforupdates
            // 
            this.Checkforupdates.CheckOnClick = true;
            this.Checkforupdates.Name = "Checkforupdates";
            this.Checkforupdates.Size = new System.Drawing.Size(228, 22);
            this.Checkforupdates.Text = "检查更新";
            this.Checkforupdates.CheckedChanged += new System.EventHandler(this.Checkforupdates_CheckedChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(225, 6);
            // 
            // Method2
            // 
            this.Method2.CheckOnClick = true;
            this.Method2.Name = "Method2";
            this.Method2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.Method2.Size = new System.Drawing.Size(228, 22);
            this.Method2.Text = "使用方法 2";
            this.Method2.ToolTipText = "trying to catch text without using ue4 asset structure (for uasset and umap only)" +
    "";
            this.Method2.CheckedChanged += new System.EventHandler(this.Method2_CheckedChanged);
            // 
            // UseFixedSize
            // 
            this.UseFixedSize.CheckOnClick = true;
            this.UseFixedSize.Name = "UseFixedSize";
            this.UseFixedSize.Size = new System.Drawing.Size(228, 22);
            this.UseFixedSize.Text = "固定尺寸";
            this.UseFixedSize.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandLinesToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.aboutToolStripMenuItem.Text = "关于";
            // 
            // commandLinesToolStripMenuItem
            // 
            this.commandLinesToolStripMenuItem.Name = "commandLinesToolStripMenuItem";
            this.commandLinesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commandLinesToolStripMenuItem.Text = "命令";
            this.commandLinesToolStripMenuItem.Click += new System.EventHandler(this.commandLinesToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donateToolStripMenuItem.Text = "捐赠";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "关于";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // DataCount
            // 
            this.DataCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DataCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DataCount.Name = "DataCount";
            this.DataCount.Size = new System.Drawing.Size(58, 21);
            this.DataCount.Text = "----------";
            // 
            // locresOprationsToolStripMenuItem
            // 
            this.locresOprationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSelectedRowToolStripMenuItem,
            this.removeSelectedRowToolStripMenuItem,
            this.addNewRowToolStripMenuItem,
            this.mergeLocresFileToolStripMenuItem,
            this.mergeUassetFileToolStripMenuItem});
            this.locresOprationsToolStripMenuItem.Name = "locresOprationsToolStripMenuItem";
            this.locresOprationsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.locresOprationsToolStripMenuItem.Text = "Locres 编辑";
            this.locresOprationsToolStripMenuItem.Visible = false;
            // 
            // editSelectedRowToolStripMenuItem
            // 
            this.editSelectedRowToolStripMenuItem.Name = "editSelectedRowToolStripMenuItem";
            this.editSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.editSelectedRowToolStripMenuItem.Text = "编辑选择行";
            this.editSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.editSelectedRowToolStripMenuItem_Click);
            // 
            // removeSelectedRowToolStripMenuItem
            // 
            this.removeSelectedRowToolStripMenuItem.Name = "removeSelectedRowToolStripMenuItem";
            this.removeSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.removeSelectedRowToolStripMenuItem.Text = "删除选择行";
            this.removeSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedRowToolStripMenuItem_Click);
            // 
            // addNewRowToolStripMenuItem
            // 
            this.addNewRowToolStripMenuItem.Name = "addNewRowToolStripMenuItem";
            this.addNewRowToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addNewRowToolStripMenuItem.Text = "添加行";
            this.addNewRowToolStripMenuItem.Click += new System.EventHandler(this.addNewRowToolStripMenuItem_Click);
            // 
            // mergeLocresFileToolStripMenuItem
            // 
            this.mergeLocresFileToolStripMenuItem.Name = "mergeLocresFileToolStripMenuItem";
            this.mergeLocresFileToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.mergeLocresFileToolStripMenuItem.Text = "合并 Locres 文件";
            this.mergeLocresFileToolStripMenuItem.Click += new System.EventHandler(this.mergeLocresFileToolStripMenuItem_Click);
            // 
            // mergeUassetFileToolStripMenuItem
            // 
            this.mergeUassetFileToolStripMenuItem.Name = "mergeUassetFileToolStripMenuItem";
            this.mergeUassetFileToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.mergeUassetFileToolStripMenuItem.Text = "合并 Uasset 文件 (Beta)";
            this.mergeUassetFileToolStripMenuItem.Click += new System.EventHandler(this.mergeUassetFileToolStripMenuItem_Click);
            // 
            // StateLabel
            // 
            this.StateLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(57, 21);
            this.StateLabel.Text = "----------";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextName,
            this.TextValue,
            this.Index});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView1.IsFilterApplied = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(689, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.FilterApplied += new System.EventHandler(this.dataGridView1_FilterApplied);
            this.dataGridView1.FilterCleared += new System.EventHandler(this.dataGridView1_FilterCleared);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // TextName
            // 
            this.TextName.HeaderText = "Name";
            this.TextName.MaxInputLength = 2147483647;
            this.TextName.MinimumWidth = 6;
            this.TextName.Name = "TextName";
            this.TextName.ReadOnly = true;
            this.TextName.Width = 125;
            // 
            // TextValue
            // 
            this.TextValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TextValue.HeaderText = "Text Value";
            this.TextValue.MaxInputLength = 2147483647;
            this.TextValue.MinimumWidth = 6;
            this.TextValue.Name = "TextValue";
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Visible = false;
            this.Index.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 23);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.AutoSize = true;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.DataGridView = this.dataGridView1;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox.Location = new System.Drawing.Point(0, 380);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(689, 35);
            this.searchBox.TabIndex = 2;
            this.searchBox.Visible = false;
            this.searchBox.Load += new System.EventHandler(this.searchBox_Load);
            // 
            // StatusBlock
            // 
            this.StatusBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusBlock.AutoSize = true;
            this.StatusBlock.BackColor = System.Drawing.Color.White;
            this.StatusBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusBlock.Controls.Add(this.StatusText);
            this.StatusBlock.Controls.Add(this.StatusTitle);
            this.StatusBlock.Controls.Add(this.pictureBox2);
            this.StatusBlock.Location = new System.Drawing.Point(189, 161);
            this.StatusBlock.Name = "StatusBlock";
            this.StatusBlock.Size = new System.Drawing.Size(310, 95);
            this.StatusBlock.TabIndex = 8;
            this.StatusBlock.Visible = false;
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(106, 60);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(47, 12);
            this.StatusText.TabIndex = 2;
            this.StatusText.Text = "-------";
            // 
            // StatusTitle
            // 
            this.StatusTitle.AutoSize = true;
            this.StatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTitle.Location = new System.Drawing.Point(103, 20);
            this.StatusTitle.Name = "StatusTitle";
            this.StatusTitle.Size = new System.Drawing.Size(114, 31);
            this.StatusTitle.TabIndex = 0;
            this.StatusTitle.Text = "----------";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 415);
            this.Controls.Add(this.StatusBlock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.searchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(704, 453);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UE4 localizations Tool";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StatusBlock.ResumeLayout(false);
            this.StatusBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAllTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private NDataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem UseFixedSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Method2;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.ToolStripMenuItem Checkforupdates;
        private System.Windows.Forms.ToolStripMenuItem csvFileToolStripMenuItem;
        private Controls.SearchBox searchBox;
        private System.Windows.Forms.ToolStripMenuItem clearFilterToolStripMenuItem;
        private ToolStripLabel StateLabel;
        private ToolStripLabel DataCount;
        private ToolStripMenuItem locresOprationsToolStripMenuItem;
        private ToolStripMenuItem editSelectedRowToolStripMenuItem;
        private ToolStripMenuItem removeSelectedRowToolStripMenuItem;
        private ToolStripMenuItem addNewRowToolStripMenuItem;
        private ToolStripMenuItem mergeLocresFileToolStripMenuItem;
        private Label StatusText;
        private Label StatusTitle;
        private PictureBox pictureBox2;
        private Panel StatusBlock;
        private ToolStripMenuItem mergeUassetFileToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
    }
}


namespace JamesNotes.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            LineStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            LenStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AOTStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            lowerCaseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            camelCaseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            formatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlMain = new System.Windows.Forms.Panel();
            lblTrimSpaces = new System.Windows.Forms.LinkLabel();
            lblInSQLInteger = new System.Windows.Forms.LinkLabel();
            lblInSQL = new System.Windows.Forms.LinkLabel();
            lblRemoveDuplicates = new System.Windows.Forms.LinkLabel();
            rtxtMain = new System.Windows.Forms.TextBox();
            statusStrip1.SuspendLayout();
            menuStripMain.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { LineStripStatusLabel, LenStripStatusLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 522);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(730, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LineStripStatusLabel
            // 
            LineStripStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            LineStripStatusLabel.ForeColor = System.Drawing.Color.Black;
            LineStripStatusLabel.Name = "LineStripStatusLabel";
            LineStripStatusLabel.Size = new System.Drawing.Size(41, 20);
            LineStripStatusLabel.Text = "Line:";
            // 
            // LenStripStatusLabel
            // 
            LenStripStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            LenStripStatusLabel.Name = "LenStripStatusLabel";
            LenStripStatusLabel.Size = new System.Drawing.Size(37, 20);
            LenStripStatusLabel.Text = "Len:";
            // 
            // menuStripMain
            // 
            menuStripMain.BackColor = System.Drawing.Color.White;
            menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            menuStripMain.Size = new System.Drawing.Size(730, 30);
            menuStripMain.TabIndex = 4;
            menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { AOTStripMenuItem, toolStripSeparator6, newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // AOTStripMenuItem
            // 
            AOTStripMenuItem.CheckOnClick = true;
            AOTStripMenuItem.Name = "AOTStripMenuItem";
            AOTStripMenuItem.Size = new System.Drawing.Size(188, 26);
            AOTStripMenuItem.Text = "Always on Top";
            AOTStripMenuItem.Click += AOTStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(185, 6);
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            newToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(185, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
            printToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem, toolStripSeparator7, lowerCaseStripMenuItem, camelCaseStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            undoToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y;
            redoToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(305, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            cutToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            cutToolStripMenuItem.Text = "Cu&t";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(305, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(305, 6);
            // 
            // lowerCaseStripMenuItem
            // 
            lowerCaseStripMenuItem.Name = "lowerCaseStripMenuItem";
            lowerCaseStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
            lowerCaseStripMenuItem.Size = new System.Drawing.Size(308, 26);
            lowerCaseStripMenuItem.Text = "Lower Case | Upper Case";
            lowerCaseStripMenuItem.Click += lowerCaseStripMenuItem_Click;
            // 
            // camelCaseStripMenuItem
            // 
            camelCaseStripMenuItem.Name = "camelCaseStripMenuItem";
            camelCaseStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W;
            camelCaseStripMenuItem.Size = new System.Drawing.Size(308, 26);
            camelCaseStripMenuItem.Text = "Camel Case";
            camelCaseStripMenuItem.Click += camelCaseStripMenuItem_Click;
            // 
            // viewStripMenuItem
            // 
            viewStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { formatStripMenuItem });
            viewStripMenuItem.Name = "viewStripMenuItem";
            viewStripMenuItem.Size = new System.Drawing.Size(55, 24);
            viewStripMenuItem.Text = "View";
            // 
            // formatStripMenuItem
            // 
            formatStripMenuItem.Name = "formatStripMenuItem";
            formatStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F;
            formatStripMenuItem.Size = new System.Drawing.Size(243, 26);
            formatStripMenuItem.Text = "Format SideBar";
            formatStripMenuItem.Click += formatStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMain.Controls.Add(lblTrimSpaces);
            pnlMain.Controls.Add(lblInSQLInteger);
            pnlMain.Controls.Add(lblInSQL);
            pnlMain.Controls.Add(lblRemoveDuplicates);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            pnlMain.Location = new System.Drawing.Point(730, 0);
            pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(289, 548);
            pnlMain.TabIndex = 6;
            pnlMain.Visible = false;
            // 
            // lblTrimSpaces
            // 
            lblTrimSpaces.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            lblTrimSpaces.AutoSize = true;
            lblTrimSpaces.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTrimSpaces.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            lblTrimSpaces.LinkColor = System.Drawing.Color.CornflowerBlue;
            lblTrimSpaces.Location = new System.Drawing.Point(21, 48);
            lblTrimSpaces.Name = "lblTrimSpaces";
            lblTrimSpaces.Size = new System.Drawing.Size(88, 20);
            lblTrimSpaces.TabIndex = 3;
            lblTrimSpaces.TabStop = true;
            lblTrimSpaces.Text = "Trim Spaces";
            lblTrimSpaces.LinkClicked += lblTrimSpaces_LinkClicked;
            // 
            // lblInSQLInteger
            // 
            lblInSQLInteger.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            lblInSQLInteger.AutoSize = true;
            lblInSQLInteger.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblInSQLInteger.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            lblInSQLInteger.LinkColor = System.Drawing.Color.CornflowerBlue;
            lblInSQLInteger.Location = new System.Drawing.Point(21, 112);
            lblInSQLInteger.Name = "lblInSQLInteger";
            lblInSQLInteger.Size = new System.Drawing.Size(107, 20);
            lblInSQLInteger.TabIndex = 3;
            lblInSQLInteger.TabStop = true;
            lblInSQLInteger.Text = "IN-SQL Integer";
            lblInSQLInteger.LinkClicked += lblInSQLInteger_LinkClicked;
            // 
            // lblInSQL
            // 
            lblInSQL.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            lblInSQL.AutoSize = true;
            lblInSQL.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblInSQL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            lblInSQL.LinkColor = System.Drawing.Color.CornflowerBlue;
            lblInSQL.Location = new System.Drawing.Point(21, 87);
            lblInSQL.Name = "lblInSQL";
            lblInSQL.Size = new System.Drawing.Size(99, 20);
            lblInSQL.TabIndex = 3;
            lblInSQL.TabStop = true;
            lblInSQL.Text = "IN-SQL String";
            lblInSQL.LinkClicked += lblInSQL_LinkClicked;
            // 
            // lblRemoveDuplicates
            // 
            lblRemoveDuplicates.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            lblRemoveDuplicates.AutoSize = true;
            lblRemoveDuplicates.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblRemoveDuplicates.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            lblRemoveDuplicates.LinkColor = System.Drawing.Color.CornflowerBlue;
            lblRemoveDuplicates.Location = new System.Drawing.Point(21, 23);
            lblRemoveDuplicates.Name = "lblRemoveDuplicates";
            lblRemoveDuplicates.Size = new System.Drawing.Size(137, 20);
            lblRemoveDuplicates.TabIndex = 3;
            lblRemoveDuplicates.TabStop = true;
            lblRemoveDuplicates.Text = "Remove Duplicates";
            lblRemoveDuplicates.LinkClicked += lblRemoveDuplicates_LinkClicked;
            // 
            // rtxtMain
            // 
            rtxtMain.BackColor = System.Drawing.Color.White;
            rtxtMain.Font = new System.Drawing.Font("Consolas", 9.75F);
            rtxtMain.ForeColor = System.Drawing.Color.Black;
            rtxtMain.Location = new System.Drawing.Point(0, 30);
            rtxtMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rtxtMain.Multiline = true;
            rtxtMain.Name = "rtxtMain";
            rtxtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            rtxtMain.Size = new System.Drawing.Size(1019, 514);
            rtxtMain.TabIndex = 7;
            rtxtMain.TextChanged += rtxtMain_TextChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1019, 548);
            Controls.Add(menuStripMain);
            Controls.Add(statusStrip1);
            Controls.Add(pnlMain);
            Controls.Add(rtxtMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "JamesPad";
            Load += frmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AOTStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox rtxtMain;
        private System.Windows.Forms.ToolStripMenuItem viewStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel LineStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LenStripStatusLabel;
        private System.Windows.Forms.LinkLabel lblRemoveDuplicates;
        private System.Windows.Forms.LinkLabel lblInSQLInteger;
        private System.Windows.Forms.LinkLabel lblInSQL;
        private System.Windows.Forms.LinkLabel lblTrimSpaces;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem lowerCaseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camelCaseStripMenuItem;
    }
}
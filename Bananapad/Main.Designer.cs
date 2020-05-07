namespace Bananapad {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel = new System.Windows.Forms.Panel();
            this.textBox = new FixedRichTextBox();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.EncStatusBar = new System.Windows.Forms.StatusBarPanel();
            this.WordsStatusBar = new System.Windows.Forms.StatusBarPanel();
            this.CharStatusBar = new System.Windows.Forms.StatusBarPanel();
            this.SelectedStatusBar = new System.Windows.Forms.StatusBarPanel();
            this.LinesStatusBar = new System.Windows.Forms.StatusBarPanel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenuItem = new System.Windows.Forms.MenuItem();
            this.NewWindowMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.NewMenuItem = new System.Windows.Forms.MenuItem();
            this.OpenMenuItem = new System.Windows.Forms.MenuItem();
            this.ReloadMenuItem = new System.Windows.Forms.MenuItem();
            this.RecentMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.SaveMenuItem = new System.Windows.Forms.MenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.PrintMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.EditMenuItem = new System.Windows.Forms.MenuItem();
            this.UndoMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.CutMenuItem = new System.Windows.Forms.MenuItem();
            this.CopyMenuItem = new System.Windows.Forms.MenuItem();
            this.PasteMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.FindMenuItem = new System.Windows.Forms.MenuItem();
            this.ReplaceMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.SelectAllMenuItem = new System.Windows.Forms.MenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.SearchGoogleMenuItem = new System.Windows.Forms.MenuItem();
            this.FormatMenuItem = new System.Windows.Forms.MenuItem();
            this.WordWrapMenuItem = new System.Windows.Forms.MenuItem();
            this.FontMenuItem = new System.Windows.Forms.MenuItem();
            this.ViewMenuItem = new System.Windows.Forms.MenuItem();
            this.ZoomMenuItem = new System.Windows.Forms.MenuItem();
            this.ZoomInMenuItem = new System.Windows.Forms.MenuItem();
            this.ZoomOutMenuItem = new System.Windows.Forms.MenuItem();
            this.ResetZoomMenuItem = new System.Windows.Forms.MenuItem();
            this.ShowStatusBarMenuItem = new System.Windows.Forms.MenuItem();
            this.HelpMenuItem = new System.Windows.Forms.MenuItem();
            this.AboutMenuItem = new System.Windows.Forms.MenuItem();
            this.textBoxCtxMenu = new System.Windows.Forms.ContextMenu();
            this.UndoCtxMenu = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.CutCtxMenu = new System.Windows.Forms.MenuItem();
            this.CopyCtxMenu = new System.Windows.Forms.MenuItem();
            this.PasteCtxMenu = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.FindCtxMenu = new System.Windows.Forms.MenuItem();
            this.ReplaceCtxMenu = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.SelectAllCtxMenu = new System.Windows.Forms.MenuItem();
            this.DeleteCtxMenu = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.ReadRighToLeftCtxMenu = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.SearchGoogleCtxMenu = new System.Windows.Forms.MenuItem();
            this.statusBarCtxMenu = new System.Windows.Forms.ContextMenu();
            this.ShowStatusBarCtxMenu = new System.Windows.Forms.MenuItem();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EncStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordsStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesStatusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(734, 316);
            this.panel.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.EnableAutoDragDrop = true;
            this.textBox.Font = new System.Drawing.Font("Consolas", 11F);
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(734, 316);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            this.textBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.linkClicked);
            this.textBox.SelectionChanged += new System.EventHandler(this.selectionChanged);
            this.textBox.FontChanged += new System.EventHandler(this.fontChanged);
            this.textBox.RightToLeftChanged += new System.EventHandler(this.rightToLeftChanged);
            this.textBox.TextChanged += new System.EventHandler(this.textBoxChangedEvent);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyDownEvent);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 316);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.EncStatusBar,
            this.WordsStatusBar,
            this.CharStatusBar,
            this.SelectedStatusBar,
            this.LinesStatusBar});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(734, 24);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // EncStatusBar
            // 
            this.EncStatusBar.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.EncStatusBar.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.EncStatusBar.MinWidth = 15;
            this.EncStatusBar.Name = "EncStatusBar";
            this.EncStatusBar.Text = "UTF-8   ";
            this.EncStatusBar.ToolTipText = "Encoding";
            this.EncStatusBar.Width = 480;
            // 
            // WordsStatusBar
            // 
            this.WordsStatusBar.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.WordsStatusBar.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.WordsStatusBar.MinWidth = 60;
            this.WordsStatusBar.Name = "WordsStatusBar";
            this.WordsStatusBar.Text = "0 Words";
            this.WordsStatusBar.ToolTipText = "Word Count";
            this.WordsStatusBar.Width = 60;
            // 
            // CharStatusBar
            // 
            this.CharStatusBar.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharStatusBar.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.CharStatusBar.MinWidth = 50;
            this.CharStatusBar.Name = "CharStatusBar";
            this.CharStatusBar.Text = "0 Char.";
            this.CharStatusBar.ToolTipText = "Character Count";
            this.CharStatusBar.Width = 51;
            // 
            // SelectedStatusBar
            // 
            this.SelectedStatusBar.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectedStatusBar.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.SelectedStatusBar.MinWidth = 75;
            this.SelectedStatusBar.Name = "SelectedStatusBar";
            this.SelectedStatusBar.Text = "0 Selected";
            this.SelectedStatusBar.ToolTipText = "Selected Characters Count";
            this.SelectedStatusBar.Width = 75;
            // 
            // LinesStatusBar
            // 
            this.LinesStatusBar.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LinesStatusBar.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.LinesStatusBar.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.LinesStatusBar.MinWidth = 50;
            this.LinesStatusBar.Name = "LinesStatusBar";
            this.LinesStatusBar.Text = "1 Lines";
            this.LinesStatusBar.ToolTipText = "Line Count";
            this.LinesStatusBar.Width = 51;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text document|*.txt|All files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text document|*.txt|All files|*.*";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Consolas", 11F);
            this.fontDialog.MinSize = 5;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.FormatMenuItem,
            this.ViewMenuItem,
            this.HelpMenuItem});
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Index = 0;
            this.FileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NewWindowMenuItem,
            this.menuItem7,
            this.NewMenuItem,
            this.OpenMenuItem,
            this.ReloadMenuItem,
            this.RecentMenuItem,
            this.menuItem12,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.menuItem15,
            this.PrintMenuItem,
            this.menuItem17,
            this.ExitMenuItem});
            this.FileMenuItem.Text = "File";
            // 
            // NewWindowMenuItem
            // 
            this.NewWindowMenuItem.Index = 0;
            this.NewWindowMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
            this.NewWindowMenuItem.Text = "New Window";
            this.NewWindowMenuItem.Click += new System.EventHandler(this.newWindowClick);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "-";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Index = 2;
            this.NewMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.NewMenuItem.Text = "New";
            this.NewMenuItem.Click += new System.EventHandler(this.newFile);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Index = 3;
            this.OpenMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.OpenMenuItem.Text = "Open...";
            this.OpenMenuItem.Click += new System.EventHandler(this.openFileClick);
            // 
            // ReloadMenuItem
            // 
            this.ReloadMenuItem.Index = 4;
            this.ReloadMenuItem.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.ReloadMenuItem.Text = "Reload";
            this.ReloadMenuItem.Click += new System.EventHandler(this.reloadFileClick);
            // 
            // RecentMenuItem
            // 
            this.RecentMenuItem.Index = 5;
            this.RecentMenuItem.Text = "Recent Files";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 6;
            this.menuItem12.Text = "-";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Index = 7;
            this.SaveMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.saveFile);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Index = 8;
            this.SaveAsMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.SaveAsMenuItem.Text = "Save As...";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.saveFileAs);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 9;
            this.menuItem15.Text = "-";
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Index = 10;
            this.PrintMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.PrintMenuItem.Text = "Print...";
            this.PrintMenuItem.Click += new System.EventHandler(this.printFile);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 11;
            this.menuItem17.Text = "-";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Index = 12;
            this.ExitMenuItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Index = 1;
            this.EditMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.UndoMenuItem,
            this.menuItem20,
            this.CutMenuItem,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.menuItem24,
            this.FindMenuItem,
            this.ReplaceMenuItem,
            this.menuItem27,
            this.SelectAllMenuItem,
            this.DeleteMenuItem,
            this.menuItem30,
            this.SearchGoogleMenuItem});
            this.EditMenuItem.Text = "Edit";
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Index = 0;
            this.UndoMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.UndoMenuItem.Text = "Undo";
            this.UndoMenuItem.Click += new System.EventHandler(this.undoText);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 1;
            this.menuItem20.Text = "-";
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Index = 2;
            this.CutMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.CutMenuItem.Text = "Cut";
            this.CutMenuItem.Click += new System.EventHandler(this.cutText);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Index = 3;
            this.CopyMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.copyText);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Index = 4;
            this.PasteMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.PasteMenuItem.Text = "Paste";
            this.PasteMenuItem.Click += new System.EventHandler(this.pasteText);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 5;
            this.menuItem24.Text = "-";
            // 
            // FindMenuItem
            // 
            this.FindMenuItem.Index = 6;
            this.FindMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.FindMenuItem.Text = "Find...";
            this.FindMenuItem.Click += new System.EventHandler(this.findText);
            // 
            // ReplaceMenuItem
            // 
            this.ReplaceMenuItem.Index = 7;
            this.ReplaceMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.ReplaceMenuItem.Text = "Replace...";
            this.ReplaceMenuItem.Click += new System.EventHandler(this.replaceText);
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 8;
            this.menuItem27.Text = "-";
            // 
            // SelectAllMenuItem
            // 
            this.SelectAllMenuItem.Index = 9;
            this.SelectAllMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.SelectAllMenuItem.Text = "Select All";
            this.SelectAllMenuItem.Click += new System.EventHandler(this.selectAllText);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Index = 10;
            this.DeleteMenuItem.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.deleteSelectedText);
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 11;
            this.menuItem30.Text = "-";
            // 
            // SearchGoogleMenuItem
            // 
            this.SearchGoogleMenuItem.Index = 12;
            this.SearchGoogleMenuItem.Text = "Search in Google";
            this.SearchGoogleMenuItem.Click += new System.EventHandler(this.searchGoogleClick);
            // 
            // FormatMenuItem
            // 
            this.FormatMenuItem.Index = 2;
            this.FormatMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.WordWrapMenuItem,
            this.FontMenuItem});
            this.FormatMenuItem.Text = "Format";
            // 
            // WordWrapMenuItem
            // 
            this.WordWrapMenuItem.Checked = true;
            this.WordWrapMenuItem.Index = 0;
            this.WordWrapMenuItem.Text = "Word Wrap";
            this.WordWrapMenuItem.Click += new System.EventHandler(this.wordWrapChanged);
            // 
            // FontMenuItem
            // 
            this.FontMenuItem.Index = 1;
            this.FontMenuItem.Text = "Font...";
            this.FontMenuItem.Click += new System.EventHandler(this.fontClick);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.Index = 3;
            this.ViewMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ZoomMenuItem,
            this.ShowStatusBarMenuItem});
            this.ViewMenuItem.Text = "View";
            // 
            // ZoomMenuItem
            // 
            this.ZoomMenuItem.Index = 0;
            this.ZoomMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ZoomInMenuItem,
            this.ZoomOutMenuItem,
            this.ResetZoomMenuItem});
            this.ZoomMenuItem.Text = "Zoom";
            // 
            // ZoomInMenuItem
            // 
            this.ZoomInMenuItem.Index = 0;
            this.ZoomInMenuItem.Text = "Zoom in";
            this.ZoomInMenuItem.Click += new System.EventHandler(this.zoomInClicked);
            // 
            // ZoomOutMenuItem
            // 
            this.ZoomOutMenuItem.Index = 1;
            this.ZoomOutMenuItem.Text = "Zoom out";
            this.ZoomOutMenuItem.Click += new System.EventHandler(this.zoomOutClicked);
            // 
            // ResetZoomMenuItem
            // 
            this.ResetZoomMenuItem.Index = 2;
            this.ResetZoomMenuItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl0;
            this.ResetZoomMenuItem.Text = "Reset Zoom";
            this.ResetZoomMenuItem.Click += new System.EventHandler(this.resetZoomClicked);
            // 
            // ShowStatusBarMenuItem
            // 
            this.ShowStatusBarMenuItem.Checked = true;
            this.ShowStatusBarMenuItem.Index = 1;
            this.ShowStatusBarMenuItem.Text = "Show Status Bar";
            this.ShowStatusBarMenuItem.Click += new System.EventHandler(this.showStatusBarMenuChanged);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Index = 4;
            this.HelpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Index = 0;
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.aboutWindow);
            // 
            // textBoxCtxMenu
            // 
            this.textBoxCtxMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.UndoCtxMenu,
            this.menuItem2,
            this.CutCtxMenu,
            this.CopyCtxMenu,
            this.PasteCtxMenu,
            this.menuItem6,
            this.FindCtxMenu,
            this.ReplaceCtxMenu,
            this.menuItem10,
            this.SelectAllCtxMenu,
            this.DeleteCtxMenu,
            this.menuItem14,
            this.ReadRighToLeftCtxMenu,
            this.menuItem19,
            this.SearchGoogleCtxMenu});
            // 
            // UndoCtxMenu
            // 
            this.UndoCtxMenu.Index = 0;
            this.UndoCtxMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.UndoCtxMenu.Text = "Undo";
            this.UndoCtxMenu.Click += new System.EventHandler(this.undoText);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // CutCtxMenu
            // 
            this.CutCtxMenu.Index = 2;
            this.CutCtxMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.CutCtxMenu.Text = "Cut";
            this.CutCtxMenu.Click += new System.EventHandler(this.cutText);
            // 
            // CopyCtxMenu
            // 
            this.CopyCtxMenu.Index = 3;
            this.CopyCtxMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.CopyCtxMenu.Text = "Copy";
            this.CopyCtxMenu.Click += new System.EventHandler(this.copyText);
            // 
            // PasteCtxMenu
            // 
            this.PasteCtxMenu.Index = 4;
            this.PasteCtxMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.PasteCtxMenu.Text = "Paste";
            this.PasteCtxMenu.Click += new System.EventHandler(this.pasteText);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.Text = "-";
            // 
            // FindCtxMenu
            // 
            this.FindCtxMenu.Index = 6;
            this.FindCtxMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.FindCtxMenu.Text = "Find...";
            this.FindCtxMenu.Click += new System.EventHandler(this.findText);
            // 
            // ReplaceCtxMenu
            // 
            this.ReplaceCtxMenu.Index = 7;
            this.ReplaceCtxMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.ReplaceCtxMenu.Text = "Replace...";
            this.ReplaceCtxMenu.Click += new System.EventHandler(this.replaceText);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 8;
            this.menuItem10.Text = "-";
            // 
            // SelectAllCtxMenu
            // 
            this.SelectAllCtxMenu.Index = 9;
            this.SelectAllCtxMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.SelectAllCtxMenu.Text = "Select All";
            this.SelectAllCtxMenu.Click += new System.EventHandler(this.selectAllText);
            // 
            // DeleteCtxMenu
            // 
            this.DeleteCtxMenu.Index = 10;
            this.DeleteCtxMenu.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.DeleteCtxMenu.Text = "Delete";
            this.DeleteCtxMenu.Click += new System.EventHandler(this.deleteSelectedText);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 11;
            this.menuItem14.Text = "-";
            // 
            // ReadRighToLeftCtxMenu
            // 
            this.ReadRighToLeftCtxMenu.Index = 12;
            this.ReadRighToLeftCtxMenu.Text = "Read Right to Left";
            this.ReadRighToLeftCtxMenu.Click += new System.EventHandler(this.righToLeftChanged);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 13;
            this.menuItem19.Text = "-";
            // 
            // SearchGoogleCtxMenu
            // 
            this.SearchGoogleCtxMenu.Index = 14;
            this.SearchGoogleCtxMenu.Text = "Search in Google";
            this.SearchGoogleCtxMenu.Click += new System.EventHandler(this.searchGoogleClick);
            // 
            // statusBarCtxMenu
            // 
            this.statusBarCtxMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ShowStatusBarCtxMenu});
            // 
            // ShowStatusBarCtxMenu
            // 
            this.ShowStatusBarCtxMenu.Checked = true;
            this.ShowStatusBarCtxMenu.Index = 0;
            this.ShowStatusBarCtxMenu.Text = "Show";
            this.ShowStatusBarCtxMenu.Click += new System.EventHandler(this.showStatusBarCtxMenuChanged);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(734, 340);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.mainMenu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BANANAPAD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromClosingEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEventHandler);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EncStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordsStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesStatusBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private FixedRichTextBox textBox;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem FileMenuItem;
        private System.Windows.Forms.MenuItem EditMenuItem;
        private System.Windows.Forms.MenuItem FormatMenuItem;
        private System.Windows.Forms.MenuItem ViewMenuItem;
        private System.Windows.Forms.MenuItem HelpMenuItem;
        private System.Windows.Forms.MenuItem NewWindowMenuItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem NewMenuItem;
        private System.Windows.Forms.MenuItem OpenMenuItem;
        private System.Windows.Forms.MenuItem ReloadMenuItem;
        private System.Windows.Forms.MenuItem RecentMenuItem;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem SaveMenuItem;
        private System.Windows.Forms.MenuItem SaveAsMenuItem;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem PrintMenuItem;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem ExitMenuItem;
        private System.Windows.Forms.MenuItem UndoMenuItem;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem CutMenuItem;
        private System.Windows.Forms.MenuItem CopyMenuItem;
        private System.Windows.Forms.MenuItem PasteMenuItem;
        private System.Windows.Forms.MenuItem menuItem24;
        private System.Windows.Forms.MenuItem FindMenuItem;
        private System.Windows.Forms.MenuItem ReplaceMenuItem;
        private System.Windows.Forms.MenuItem menuItem27;
        private System.Windows.Forms.MenuItem SelectAllMenuItem;
        private System.Windows.Forms.MenuItem DeleteMenuItem;
        private System.Windows.Forms.MenuItem menuItem30;
        private System.Windows.Forms.MenuItem SearchGoogleMenuItem;
        private System.Windows.Forms.MenuItem WordWrapMenuItem;
        private System.Windows.Forms.MenuItem FontMenuItem;
        private System.Windows.Forms.MenuItem ZoomMenuItem;
        private System.Windows.Forms.MenuItem ZoomInMenuItem;
        private System.Windows.Forms.MenuItem ZoomOutMenuItem;
        private System.Windows.Forms.MenuItem ResetZoomMenuItem;
        private System.Windows.Forms.MenuItem AboutMenuItem;
        private System.Windows.Forms.MenuItem ShowStatusBarMenuItem;
        private System.Windows.Forms.ContextMenu textBoxCtxMenu;
        private System.Windows.Forms.MenuItem UndoCtxMenu;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem CutCtxMenu;
        private System.Windows.Forms.MenuItem CopyCtxMenu;
        private System.Windows.Forms.MenuItem PasteCtxMenu;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem FindCtxMenu;
        private System.Windows.Forms.MenuItem ReplaceCtxMenu;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem SelectAllCtxMenu;
        private System.Windows.Forms.MenuItem DeleteCtxMenu;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem SearchGoogleCtxMenu;
        private System.Windows.Forms.MenuItem ReadRighToLeftCtxMenu;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.ContextMenu statusBarCtxMenu;
        private System.Windows.Forms.MenuItem ShowStatusBarCtxMenu;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.StatusBarPanel LinesStatusBar;
        private System.Windows.Forms.StatusBarPanel SelectedStatusBar;
        private System.Windows.Forms.StatusBarPanel CharStatusBar;
        private System.Windows.Forms.StatusBarPanel WordsStatusBar;
        private System.Windows.Forms.StatusBarPanel EncStatusBar;
    }
}


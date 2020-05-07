using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.Menu;
using MenuItem = System.Windows.Forms.MenuItem;

namespace Bananapad {
    public partial class Main: Form {

        #region Variables
        // Strings
        const string titlePrefix = " - Bananapad";
        string oldTextBoxVal = string.Empty;
        string _file = string.Empty;
        string currentFile {
            get {
                return _file;
            }
            set {
                _file = value;
                if (!string.IsNullOrEmpty(_file)) {
                    textBox.ClearUndo();
                    addRecentFile(_file);

                    // File Watcher
                    fileWatcher = new FileSystemWatcher();
                    fileWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Attributes;
                    fileWatcher.Path = Path.GetDirectoryName(_file);
                    fileWatcher.Filter = Path.GetFileName(_file);
                    fileWatcher.Changed += fileWatcherChangeEvent;
                    fileWatcher.Deleted += fileWatcherChangeEvent;
                    fileWatcher.Renamed += fileWatcherChangeEvent;
                    fileWatcher.EnableRaisingEvents = true;
                }
            }
        }

        // Windows
        FindReplace_Dialog find_replaceDialog;

        // Booleans
        bool isNewWindow = false;
        bool isDropping = false;
        bool isChanged = false;
        bool _saved = true;
        bool isSaved {
            get {
                return _saved;
            }
            set {
                _saved = value;
                Text = mainLib.addSaveMark(Text, value);
            }
        }

        // Ints
        const int recentLimit = 5;

        // Lists
        List<string> recentFiles = new List<string>();

        // Paths
        string recentFilesPath = Application.UserAppDataPath + "\\recent_files.json";

        // Libraries
        banana_library.Main mainLib = new banana_library.Main();

        // File Watcher
        FileSystemWatcher fileWatcher;
        #endregion

        public Main() {
            InitializeComponent();

            find_replaceDialog = new FindReplace_Dialog(this);

            // Events
            printDocument.PrintPage += new PrintPageEventHandler(printPage);
            textBox.DragDrop += textBoxDropFileEvent;
            textBox.GotFocus += textBoxGotFocusEvent;
            // Context Menu
            textBox.ContextMenu = textBoxCtxMenu;
            statusBar.ContextMenu = statusBarCtxMenu;

            // CommandLineArgs
            string[] Args = Environment.GetCommandLineArgs();
            if (Args.Length > 1) {
                if (Args[1].Equals("--new-window")) {
                    isNewWindow = true;
                }
                else {
                    currentFile = Args[1];
                }
            }

            // Settings
            getSettings();
        }

        #region Form
        private void setTitle(string title) {
            Text = title + titlePrefix;
        }

        private void newWindowClick(object sender, EventArgs e) {
            saveSettings();
            Process.Start(Application.ExecutablePath, "--new-window");
        }

        private void Exit(object sender, EventArgs e) {
            Close();
        }

        private void FromClosingEvent(object sender, FormClosingEventArgs e) {
            saveSettings();

            if (!askToSave())
                e.Cancel = true;
        }

        private void KeyDownEventHandler(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.W) {
                Close();
            }
        }
        #endregion

        #region Files
        // File Watcher
        private void fileWatcherChangeEvent(object sender, FileSystemEventArgs e) {
            isChanged = true;
        }

        private void newFile(object sender, EventArgs e) {
            if (!askToSave())
                return;

            currentFile = string.Empty;
            textBox.Text = string.Empty;
            isSaved = true;
            setTitle("untitled");
        }

        private void openFileClick(object sender, EventArgs e) {
            if (askToSave()) {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    openFile(openFileDialog.FileName);
                    openFileDialog.FileName = string.Empty;
                }
            }
        }

        private void openFile(string path) {
            if (File.Exists(path)) {
                textBox.Text = File.ReadAllText(path);
                textBox.Select(textBox.Text.Length, textBox.Text.Length);
                currentFile = path;
                setTitle(Path.GetFileName(currentFile));
                isSaved = true;
            }
            else {
                MessageBox.Show("File not found (" + path + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFile(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(currentFile)) {
                SaveAsMenuItem.PerformClick();
                return;
            }

            if (isSaved)
                return;

            try {
                File.WriteAllText(currentFile, textBox.Text);
                isSaved = true;
            }
            catch (Exception ex) {
                if (ex is UnauthorizedAccessException) {
                    DialogResult result = MessageBox.Show($"Error: {ex.Message} Save somewhere else?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes) {
                        SaveAsMenuItem.PerformClick();
                    }
                }
                else {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveFileAs(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                isSaved = true;
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                currentFile = saveFileDialog.FileName;
                setTitle(Path.GetFileName(currentFile));

                saveFileDialog.FileName = string.Empty;
            }
        }

        private bool askToSave() {
            if (!isSaved) {
                DialogResult result = MessageBox.Show("Do you want to save changes before closing this file?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    SaveMenuItem.PerformClick();
                }
                else if (result == DialogResult.Cancel) {
                    return false;
                }
            }

            return true;
        }

        private List<string> getRecentFiles() {
            if (!File.Exists(recentFilesPath)) {
                return new List<string>();
            }

            string content = File.ReadAllText(recentFilesPath);
            List<string> json = JsonSerializer.Deserialize<List<string>>(content);
            json.Reverse();

            return json;
        }

        private void saveRecentFiles() {
            List<string> newList = recentFiles;
            object json = JsonSerializer.Serialize(newList);
            File.WriteAllText(recentFilesPath, json.ToString());
        }

        private void reloadFileClick(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(currentFile)) {
                if (isSaved) {
                    openFile(currentFile);
                }
                else {
                    DialogResult result = MessageBox.Show("There are unsaved changes. Are you sure you want to reload this file? All changes will be gone.", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                        openFile(currentFile);
                    }
                }
            }
        }
        #endregion

        #region Print
        private void printPage(object sender, PrintPageEventArgs e) {
            e.Graphics.DrawString(textBox.Text, textBox.Font, Brushes.Black, 20, 20);
        }

        private void printFile(object sender, EventArgs e) {
            if (textBox.TextLength == 0) {
                MessageBox.Show("Please type something before trying to print.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK) {
                printDocument.Print();
            }
        }
        #endregion

        #region TextBox
        private void textBoxGotFocusEvent(object sender, EventArgs e) {
            if (isChanged) {
                if (File.Exists(currentFile)) {
                    if (!File.ReadAllText(currentFile).Equals(textBox.Text)) {
                        DialogResult result = MessageBox.Show("File is modified. Do you want to reload it?", "File Modified", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) {
                            openFile(currentFile);
                        }
                        else {
                            isSaved = false;
                        }
                    }
                }
                else {
                    currentFile = string.Empty;
                    isSaved = false;
                }
            }

            isChanged = false;
            textBox.Focus();
        }

        private void textBoxDropFileEvent(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.None;

            object data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null) {
                string[] files = data as string[];
                if (files.Length > 0) {
                    if (askToSave()) {
                        isDropping = true;
                        openFile(files[0]);
                    }
                }
            }
        }

        private void textBoxChangedEvent(object sender, EventArgs e) {
            if (isDropping) {
                isSaved = true;
            }
            else if (!textBox.Text.Equals(oldTextBoxVal)) {
                isSaved = false;
            }

            Text = mainLib.addSaveMark(Text, isSaved);

            int[] textInfo = mainLib.getTextBoxInfo(textBox.Text);
            statusBar.Panels["CharStatusBar"].Text = textInfo[0] + " Char.";
            statusBar.Panels["WordsStatusBar"].Text = textInfo[1] + " Words";
            statusBar.Panels["LinesStatusBar"].Text = textInfo[2] + " Lines";

            oldTextBoxVal = textBox.Text;
            isDropping = false;
            isChanged = false;
        }

        private void textBoxKeyDownEvent(object sender, KeyEventArgs e) {
            // Recent files
            if (e.Control && e.Shift && (e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5)) {
                MenuItemCollection collection = RecentMenuItem.MenuItems;
                switch (e.KeyCode) {
                    case Keys.D1:
                        if (collection.Count > 0) {
                            collection[0].PerformClick();
                        }
                        break;
                    case Keys.D2:
                        if (collection.Count > 1) {
                            collection[1].PerformClick();
                        }
                        break;
                    case Keys.D3:
                        if (collection.Count > 2) {
                            collection[2].PerformClick();
                        }
                        break;
                    case Keys.D4:
                        if (collection.Count > 3) {
                            collection[3].PerformClick();
                        }
                        break;
                    case Keys.D5:
                        if (collection.Count > 4) {
                            collection[4].PerformClick();
                        }
                        break;
                }
            }
        }

        private void selectionChanged(object sender, EventArgs e) {
            statusBar.Panels["SelectedStatusBar"].Text = textBox.SelectionLength + " Selected";
        }

        private void undoText(object sender, EventArgs e) {
            textBox.Undo();
        }

        private void cutText(object sender, EventArgs e) {
            if (textBox.SelectedText.Length > 0) {
                textBox.Cut();
            }
            else {
                int line = textBox.GetLineFromCharIndex(textBox.SelectionStart);
                textBox.Select(textBox.GetFirstCharIndexFromLine(line) - 1, textBox.Lines[line].Length + 1);
                Clipboard.SetText(textBox.SelectedText);
                textBox.SelectedText = string.Empty;
            }
        }

        private void copyText(object sender, EventArgs e) {
            textBox.Copy();
        }

        private void pasteText(object sender, EventArgs e) {
            textBox.Paste();
            textBox.Text = textBox.Text;
        }

        private void selectAllText(object sender, EventArgs e) {
            textBox.SelectAll();
        }

        private void deleteSelectedText(object sender, EventArgs e) {
            if (textBox.SelectedText.Length > 0)
                textBox.SelectedText = string.Empty;
            else {
                textBox.Select(textBox.SelectionStart, 1);
                textBox.SelectedText = string.Empty;
            }
        }

        private void findText(object sender, EventArgs e) {
            find_replaceDialog.ShowWindow(textBox.SelectedText, 0);
        }

        private void replaceText(object sender, EventArgs e) {
            find_replaceDialog.ShowWindow(textBox.SelectedText, 1);
        }

        public int findNextText(string text, int index) {
            try {
                if (textBox.TextLength > 0 && ((index == 0 && textBox.Text.Contains(text)) || textBox.Text.Contains(textBox.Text.Remove(0, index)))) {
                    int start = textBox.Text.IndexOf(text, index);
                    int end = text.Length;
                    textBox.Select(start, end);
                    return (start + end);
                }
                else {
                    MessageBox.Show("Cannot find \"" + text + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception) {
                MessageBox.Show("Cannot find \"" + text + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;

                throw;
            }
        }

        public int replaceNextText(string oldText, string newText, int index) {
            try {
                string newTextBoxValue = textBox.Text.Remove(0, index);
                if (textBox.TextLength > 0 && ((index == 0 && textBox.Text.Contains(oldText)) || textBox.Text.Contains(newTextBoxValue))) {
                    int start = textBox.Text.IndexOf(oldText, index);
                    int end = newText.Length;
                    Regex replacement = new Regex(Regex.Escape(oldText));
                    textBox.Text = textBox.Text.Replace(newTextBoxValue, replacement.Replace(newTextBoxValue, newText, 1));
                    textBox.Select(start, end);
                    return (start + end);
                }
                else {
                    MessageBox.Show("Cannot find \"" + oldText + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception) {
                MessageBox.Show("Cannot find \"" + oldText + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;

                throw;
            }
        }

        public void replaceAllText(string oldText, string newText) {
            if (textBox.TextLength > 0 && textBox.Text.Contains(oldText)) {
                int count = new Regex(Regex.Escape(oldText)).Matches(textBox.Text).Count;
                textBox.Text = textBox.Text.Replace(oldText, newText);
                MessageBox.Show(count + " occurrence(s) replaced.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Cannot find \"" + oldText + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wordWrapChanged(object sender, EventArgs e) {
            WordWrapMenuItem.Checked = !WordWrapMenuItem.Checked;

            float zoomF = textBox.ZoomFactor;
            textBox.WordWrap = WordWrapMenuItem.Checked;
            textBox.ZoomFactor = zoomF;
        }

        private void fontClick(object sender, EventArgs e) {
            if (fontDialog.ShowDialog() == DialogResult.OK) {
                textBox.Font = fontDialog.Font;
            }
        }

        private void fontChanged(object sender, EventArgs e) {
            fontDialog.Font = textBox.Font;
        }

        private void rightToLeftChanged(object sender, EventArgs e) {
            textBoxCtxMenu.RightToLeft = RightToLeft.No;
        }

        private void linkClicked(object sender, LinkClickedEventArgs e) {
            try {
                DialogResult result = MessageBox.Show("Are you sure you want to open this link in external website?", "Open Link", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    Process.Start(e.LinkText);
                }
            }
            catch (Exception) {
                MessageBox.Show("An unknown error occured when oppening this link. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showStatusBarMenuChanged(object sender, EventArgs e) {
            ShowStatusBarMenuItem.Checked = !ShowStatusBarMenuItem.Checked;

            if (ShowStatusBarMenuItem.Checked) {
                statusBar.Visible = true;
            }
            else {
                statusBar.Visible = false;
            }

            ShowStatusBarCtxMenu.Checked = ShowStatusBarMenuItem.Checked;
        }

        private void showStatusBarCtxMenuChanged(object sender, EventArgs e) {
            ShowStatusBarCtxMenu.Checked = !ShowStatusBarCtxMenu.Checked;

            if (ShowStatusBarCtxMenu.Checked) {
                statusBar.Visible = true;
            }
            else {
                statusBar.Visible = false;
            }

            ShowStatusBarMenuItem.Checked = ShowStatusBarCtxMenu.Checked;
        }

        private void zoomInClicked(object sender, EventArgs e) {
            if ((textBox.ZoomFactor + .25f) < 5.15f)
                textBox.ZoomFactor = textBox.ZoomFactor + .25f;
        }

        private void zoomOutClicked(object sender, EventArgs e) {
            if ((textBox.ZoomFactor - .25f) > 0)
                textBox.ZoomFactor = textBox.ZoomFactor - .25f;
        }

        private void resetZoomClicked(object sender, EventArgs e) {
            ZoomInMenuItem.PerformClick();
            textBox.ZoomFactor = 1f;
        }

        private void righToLeftChanged(object sender, EventArgs e) {
            ReadRighToLeftCtxMenu.Checked = !ReadRighToLeftCtxMenu.Checked;

            if (ReadRighToLeftCtxMenu.Checked) {
                textBox.RightToLeft = RightToLeft.Yes;
            }
            else {
                textBox.RightToLeft = RightToLeft.No;
            }
        }

        private void searchGoogleClick(object sender, EventArgs e) {
            if (textBox.TextLength == 0) {
                MessageBox.Show("Please type something before trying to search in google.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox.TextLength >= 85) {
                MessageBox.Show("Too many characters entered (Maximum: 85). Remove some and try again.", "Too Many Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to open this link in external website?", "Open Google", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Process.Start("https://www.google.com/search?&q=" + textBox.Text);
            }
        }
        #endregion

        #region Settings
        private void getSettings() {
            bool wordWrap = Properties.Settings.Default.WordWrap;
            Font font = Properties.Settings.Default.Font;
            Point mainLocation = Properties.Settings.Default.MainLocation;
            Size mainSize = Properties.Settings.Default.MainSize;
            bool isMaximized = Properties.Settings.Default.isMaximized;
            bool showStatusBar = Properties.Settings.Default.StatusBar;
            RightToLeft rightToLeft = Properties.Settings.Default.ReadRighLeft;
            float zoomFactor = Properties.Settings.Default.ZoomFactor;
            string lastFile = Properties.Settings.Default.LastOpenedFile;

            MenuCheck(ShowStatusBarMenuItem, showStatusBar);
            MenuCheck(ShowStatusBarCtxMenu, showStatusBar);
            MenuCheck(ReadRighToLeftCtxMenu, mainLib.rightToLeftToBool(rightToLeft));
            MenuCheck(WordWrapMenuItem, wordWrap);
            statusBarCtxMenu.RightToLeft = RightToLeft.No;
            textBox.ZoomFactor = zoomFactor;
            textBox.Font = font;

            if (isMaximized)
                WindowState = FormWindowState.Maximized;
            else {
                Size = mainSize;
                WindowState = FormWindowState.Normal;
            }

            if (isNewWindow || mainLocation == new Point(0, 0))
                StartPosition = FormStartPosition.WindowsDefaultLocation;
            else {
                Location = mainLocation;
            }

            List<string> tempList = getRecentFiles();
            if (tempList.Count > 0) {
                for (int i = 0; i < tempList.Count; i++) {
                    addRecentFile(tempList[i]);
                }
            }

            if (string.IsNullOrEmpty(currentFile)) {
                if (!string.IsNullOrEmpty(lastFile) && !isNewWindow && File.Exists(lastFile))
                    openFile(lastFile);
                else
                    NewMenuItem.PerformClick();
            }
            else {
                openFile(currentFile);
            }

            // Fix SaveMark issue
            textBoxChangedEvent(null, null);
            isSaved = true;
        }

        private void saveSettings() {
            bool wordWrap = textBox.WordWrap;
            Font font = textBox.Font;
            Point mainLocation = Location;
            Size mainSize = Size;
            bool isMaximized = (WindowState == FormWindowState.Maximized);
            bool showStatusBar = ShowStatusBarMenuItem.Checked;
            RightToLeft rightToLeft = textBox.RightToLeft;
            float zoomFactor = textBox.ZoomFactor;
            string lastFile = currentFile;

            Properties.Settings.Default.WordWrap = wordWrap;
            Properties.Settings.Default.Font = font;
            Properties.Settings.Default.MainLocation = mainLocation;
            Properties.Settings.Default.MainSize = mainSize;
            Properties.Settings.Default.isMaximized = isMaximized;
            Properties.Settings.Default.StatusBar = showStatusBar;
            Properties.Settings.Default.ReadRighLeft = rightToLeft;
            Properties.Settings.Default.ZoomFactor = zoomFactor;
            Properties.Settings.Default.LastOpenedFile = lastFile;
            saveRecentFiles();

            Properties.Settings.Default.Save();
        }

        void MenuCheck(MenuItem item, bool check) {
            if (check) {
                if (!item.Checked) {
                    item.PerformClick();
                }
            }
            else {
                if (item.Checked) {
                    item.PerformClick();
                }
            }
        }

        private void recentStripMenuClick(object sender, EventArgs e) {
            MenuItem item = (MenuItem)sender;

            if (askToSave()) {
                string path = item.Text;
                openFile(path);
            }
        }

        private void addRecentFile(string path) {
            if (!File.Exists(path))
                return;

            if (recentFiles.Contains(path)) {
                MenuItem checkItem = RecentMenuItem.MenuItems[recentFiles.IndexOf(path)];

                if (RecentMenuItem.MenuItems.Contains(checkItem)) {
                    recentFiles.Remove(path);
                    RecentMenuItem.MenuItems.Remove(checkItem);
                }
            }

            recentFiles.Insert(0, path);

            MenuItem item = new MenuItem(path);
            item.Click += recentStripMenuClick;
            RecentMenuItem.MenuItems.Add(0, item);

            if (recentFiles.Count > recentLimit && RecentMenuItem.MenuItems.Count > recentLimit) {
                recentFiles.RemoveAt(recentLimit);
                RecentMenuItem.MenuItems.RemoveAt(recentLimit);
            }
        }
        #endregion

        #region Other
        // About
        private void aboutWindow(object sender, EventArgs e) {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        #endregion
    }
}
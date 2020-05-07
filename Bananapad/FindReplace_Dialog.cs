using System;
using System.Windows.Forms;

namespace Bananapad {
    public partial class FindReplace_Dialog: Form {
        #region Variables
        Main mainForm;
        int lastIndex = 0;
        #endregion

        #region Form
        public FindReplace_Dialog() {
            InitializeComponent();
        }

        public FindReplace_Dialog(Main MainForm) {
            InitializeComponent();
            mainForm = MainForm;
        }

        public void ShowWindow(string selected, int window) {
            if (!string.IsNullOrEmpty(selected) && selected.Length > 0) {
                findInput.Text = selected;
            }

            switch (window) {
                case 0:
                    findInput.Focus();
                    break;
                case 1:
                    replaceInput.Focus();
                    break;
            }

            Show();
        }

        private void KeyDownEvent(object sender, KeyEventArgs e) {
            if (e.Control && (e.KeyCode == Keys.F || e.KeyCode == Keys.W || e.KeyCode == Keys.R)) {
                Close();
            }
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            Hide();
        }
        #endregion

        #region Events
        private void FindNextClicked(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(findInput.Text))
                return;

            int newIndex = mainForm.findNextText(findInput.Text, lastIndex);
            mainForm.Focus();

            lastIndex = newIndex;
        }

        private void ReplaceNextClicked(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(findInput.Text))
                return;

            int newIndex = mainForm.replaceNextText(findInput.Text, replaceInput.Text, lastIndex);
            mainForm.Focus();

            lastIndex = newIndex;
        }

        private void ReplaceAllClicked(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(findInput.Text))
                return;

            mainForm.replaceAllText(findInput.Text, replaceInput.Text);
            mainForm.Focus();

            lastIndex = 0;
        }

        private void CancelButtonClicked(object sender, EventArgs e) {
            Close();
        }

        private void FindInputChanged(object sender, EventArgs e) {
            lastIndex = 0;
        }
        #endregion
    }
}

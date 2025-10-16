using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JamesNotes.Forms
{
    public partial class frmMain : Form
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        private bool? isInLowerCase { get; set; }


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public frmMain()
        {
            InitializeComponent();
            this.Text = $"JamesNotes - xD 1.2.0";
            rtxtMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AOTStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AOTStripMenuItem.Checked)
            {
                SetWindowPos(this.Handle, HWND_TOPMOST, 100, 100, 300, 300, TOPMOST_FLAGS); 
            }
            else
            {
                SetWindowPos(this.Handle, HWND_NOTOPMOST, 100, 100, 300, 300, TOPMOST_FLAGS);

            }
            
        }

        private void formatStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlMain.Visible == false)
                pnlMain.Visible = true;
            else
                pnlMain.Visible = false;

        }

        private void rtxtMain_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusStrip();
        }

        private void lblRemoveDuplicates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtxtMain.Text = string.Join(Environment.NewLine, rtxtMain.Lines.Distinct());
        }

        private void lblInSQL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtxtMain.Text = rtxtMain.Text.Replace("\n", "").Replace("\r", "','");
        }

        private void lblInSQLInteger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtxtMain.Text = rtxtMain.Text.Replace("\n", "").Replace("\r", ",");
        }

        private void lblTrimSpaces_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtxtMain.Text = rtxtMain.Text.Replace(" ", "");
        }

        private void UpdateStatusStrip() 
        {
            LineStripStatusLabel.Text = $"Line: {rtxtMain.Lines.Count()}";
            LenStripStatusLabel.Text = $"Len: {rtxtMain.Text.Count()}";

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtxtMain.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                rtxtMain.Copy();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtxtMain.SelectedText != "")
                // Cut the selected text in the control and paste it into the Clipboard.
                rtxtMain.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (rtxtMain.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        rtxtMain.SelectionStart = rtxtMain.SelectionStart + rtxtMain.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                rtxtMain.Paste();
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determine if last operation can be undone in text box.   
            if (rtxtMain.CanUndo == true)
            {
                // Undo the last operation.
                rtxtMain.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                rtxtMain.ClearUndo();
            }

        }

        private void lowerCaseStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isInLowerCase == null)
            { 
                rtxtMain.Text = rtxtMain.Text.ToLower();
                isInLowerCase = true;
                return;
            }

            if (isInLowerCase == true)
            {
                rtxtMain.Text = rtxtMain.Text.ToUpper();
                isInLowerCase = false;

            }
            else 
            { 
                rtxtMain.Text = rtxtMain.Text.ToLower();
                isInLowerCase = true;
            }

        }

        private void camelCaseStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtMain.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rtxtMain.Text.ToLower());
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
        }

    }
}

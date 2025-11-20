using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form2 : Form
    {
        private FontDialog fontDialog;
        private ColorDialog colorDialog;

        public Form2()
        {
            InitializeComponent();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();

            // Wire up find/replace buttons
            btnFind.Click += BtnFind_Click;
            btnFindNext.Click += BtnFindNext_Click;
            btnReplace.Click += BtnReplace_Click;
            btnReplaceAll.Click += BtnReplaceAll_Click;
            btnFont.Click += BtnFont_Click;
            btnColor.Click += BtnColor_Click;

            rtbEditor.VScroll += (s, e) => UpdateLineNumbers();
            rtbEditor.TextChanged += (s, e) => UpdateLineNumbers();
            UpdateLineNumbers();
        }

        private int lastFindIndex = -1;

        private void BtnFind_Click(object sender, EventArgs e)
        {
            lastFindIndex = -1;
            FindNext();
        }

        private void BtnFindNext_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void FindNext()
        {
            string search = txtFind.Text;
            if (string.IsNullOrEmpty(search))
                return;

            int start = rtbEditor.SelectionStart + rtbEditor.SelectionLength;
            int idx = rtbEditor.Text.IndexOf(search, start, StringComparison.CurrentCultureIgnoreCase);
            if (idx < 0)
            {
                // wrap
                idx = rtbEditor.Text.IndexOf(search, 0, StringComparison.CurrentCultureIgnoreCase);
            }
            if (idx >= 0)
            {
                rtbEditor.Select(idx, search.Length);
                rtbEditor.ScrollToCaret();
                lastFindIndex = idx;
            }
            else
            {
                MessageBox.Show("Text not found.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionLength > 0 && string.Equals(rtbEditor.SelectedText, txtFind.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                rtbEditor.SelectedText = txtReplace.Text;
            }
            FindNext();
        }

        private void BtnReplaceAll_Click(object sender, EventArgs e)
        {
            string find = txtFind.Text;
            string replace = txtReplace.Text;
            if (string.IsNullOrEmpty(find))
                return;

            rtbEditor.Text = System.Text.RegularExpressions.Regex.Replace(rtbEditor.Text, System.Text.RegularExpressions.Regex.Escape(find), replace, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = rtbEditor.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.Font = fontDialog.Font;
                UpdateLineNumbers();
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = rtbEditor.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.ForeColor = colorDialog.Color;
            }
        }

        private void UpdateLineNumbers()
        {
            int firstCharIndex = rtbEditor.GetCharIndexFromPosition(new Point(0, 0));
            int firstLine = rtbEditor.GetLineFromCharIndex(firstCharIndex);
            int lineCount = rtbEditor.Lines.Length;
            var lineNumbersText = "";
            for (int i = 0; i < lineCount; i++)
            {
                lineNumbersText += (i + 1).ToString() + Environment.NewLine;
            }
            rtbLineNumbers.Text = lineNumbersText;
        }
    }
}
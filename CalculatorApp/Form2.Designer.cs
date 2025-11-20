namespace CalculatorApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.RichTextBox rtbLineNumbers;
        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.Panel panelFindReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.rtbLineNumbers = new System.Windows.Forms.RichTextBox();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.panelFindReplace = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.panelEditor.SuspendLayout();
            this.panelFindReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditor
            // 
            this.panelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                              | System.Windows.Forms.AnchorStyles.Left)
                                                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditor.Controls.Add(this.rtbLineNumbers);
            this.panelEditor.Controls.Add(this.rtbEditor);
            this.panelEditor.Location = new System.Drawing.Point(12, 48);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(760, 401);
            this.panelEditor.TabIndex = 0;
            // 
            // rtbLineNumbers
            // 
            this.rtbLineNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rtbLineNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLineNumbers.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbLineNumbers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rtbLineNumbers.Location = new System.Drawing.Point(0, 0);
            this.rtbLineNumbers.Name = "rtbLineNumbers";
            this.rtbLineNumbers.ReadOnly = true;
            this.rtbLineNumbers.Size = new System.Drawing.Size(48, 399);
            this.rtbLineNumbers.TabIndex = 1;
            this.rtbLineNumbers.Text = "";
            this.rtbLineNumbers.WordWrap = false;
            // 
            // rtbEditor
            // 
            this.rtbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                            | System.Windows.Forms.AnchorStyles.Left)
                                                                           | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEditor.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbEditor.Location = new System.Drawing.Point(52, 0);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(706, 399);
            this.rtbEditor.TabIndex = 0;
            this.rtbEditor.Text = "";
            this.rtbEditor.WordWrap = false;
            // 
            // panelFindReplace
            // 
            this.panelFindReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFindReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFindReplace.Controls.Add(this.btnColor);
            this.panelFindReplace.Controls.Add(this.btnFont);
            this.panelFindReplace.Controls.Add(this.btnReplaceAll);
            this.panelFindReplace.Controls.Add(this.btnReplace);
            this.panelFindReplace.Controls.Add(this.btnFindNext);
            this.panelFindReplace.Controls.Add(this.btnFind);
            this.panelFindReplace.Controls.Add(this.txtReplace);
            this.panelFindReplace.Controls.Add(this.txtFind);
            this.panelFindReplace.Location = new System.Drawing.Point(12, 12);
            this.panelFindReplace.Name = "panelFindReplace";
            this.panelFindReplace.Size = new System.Drawing.Size(760, 30);
            this.panelFindReplace.TabIndex = 1;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(3, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(160, 20);
            this.txtFind.TabIndex = 0;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(170, 4);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(160, 20);
            this.txtReplace.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(336, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 24);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(402, 2);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(72, 24);
            this.btnFindNext.TabIndex = 3;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(480, 2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(72, 24);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(558, 2);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(80, 24);
            this.btnReplaceAll.TabIndex = 5;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(644, 2);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(55, 24);
            this.btnFont.TabIndex = 6;
            this.btnFont.Text = "Font...";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(701, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(54, 24);
            this.btnColor.TabIndex = 7;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelFindReplace);
            this.Controls.Add(this.panelEditor);
            this.Name = "Form2";
            this.Text = "Text Editor";
            this.panelEditor.ResumeLayout(false);
            this.panelFindReplace.ResumeLayout(false);
            this.panelFindReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
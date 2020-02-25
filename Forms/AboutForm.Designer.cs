// 
// Rika
// Copyright (C) 2020 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

namespace Rika.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.grpCredits = new System.Windows.Forms.GroupBox();
            this.pnlCreditsBorder = new System.Windows.Forms.Panel();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpCredits.SuspendLayout();
            this.pnlCreditsBorder.SuspendLayout();
            this.tpnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(155, 184);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 22);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpCredits
            // 
            this.tpnlMain.SetColumnSpan(this.grpCredits, 2);
            this.grpCredits.Controls.Add(this.pnlCreditsBorder);
            this.grpCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCredits.Location = new System.Drawing.Point(3, 3);
            this.grpCredits.Name = "grpCredits";
            this.grpCredits.Padding = new System.Windows.Forms.Padding(14, 10, 14, 14);
            this.grpCredits.Size = new System.Drawing.Size(237, 176);
            this.grpCredits.TabIndex = 0;
            this.grpCredits.TabStop = false;
            this.grpCredits.Text = "Credits";
            // 
            // pnlCreditsBorder
            // 
            this.pnlCreditsBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCreditsBorder.Controls.Add(this.txtCredits);
            this.pnlCreditsBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreditsBorder.Location = new System.Drawing.Point(14, 25);
            this.pnlCreditsBorder.Name = "pnlCreditsBorder";
            this.pnlCreditsBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlCreditsBorder.Size = new System.Drawing.Size(209, 137);
            this.pnlCreditsBorder.TabIndex = 0;
            // 
            // txtCredits
            // 
            this.txtCredits.BackColor = System.Drawing.Color.White;
            this.txtCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCredits.Location = new System.Drawing.Point(1, 1);
            this.txtCredits.Multiline = true;
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.ReadOnly = true;
            this.txtCredits.Size = new System.Drawing.Size(207, 135);
            this.txtCredits.TabIndex = 0;
            this.txtCredits.TabStop = false;
            this.txtCredits.Text = resources.GetString("txtCredits.Text");
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(3, 182);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(147, 26);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version: Alpha 1.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tpnlMain.Controls.Add(this.grpCredits, 0, 0);
            this.tpnlMain.Controls.Add(this.btnOK, 1, 1);
            this.tpnlMain.Controls.Add(this.lblVersion, 0, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(8, 8);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(243, 208);
            this.tpnlMain.TabIndex = 0;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 224);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Rika";
            this.grpCredits.ResumeLayout(false);
            this.pnlCreditsBorder.ResumeLayout(false);
            this.pnlCreditsBorder.PerformLayout();
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btnOK;

        #endregion

        private System.Windows.Forms.GroupBox grpCredits;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlCreditsBorder;
        private System.Windows.Forms.TextBox txtCredits;
    }
}
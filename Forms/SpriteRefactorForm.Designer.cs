namespace Rika.Forms
{
    partial class SpriteRefactorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefactor = new System.Windows.Forms.Button();
            this.grpRefactorResults = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpRefactorResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefactor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpRefactorResults, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRefactor
            // 
            this.btnRefactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefactor.Location = new System.Drawing.Point(300, 345);
            this.btnRefactor.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefactor.Name = "btnRefactor";
            this.btnRefactor.Size = new System.Drawing.Size(94, 26);
            this.btnRefactor.TabIndex = 1;
            this.btnRefactor.Text = "Refactor";
            this.btnRefactor.UseVisualStyleBackColor = true;
            this.btnRefactor.Click += new System.EventHandler(this.btnRefactor_Click);
            // 
            // grpRefactorResults
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpRefactorResults, 2);
            this.grpRefactorResults.Controls.Add(this.txtResults);
            this.grpRefactorResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRefactorResults.Location = new System.Drawing.Point(3, 3);
            this.grpRefactorResults.Name = "grpRefactorResults";
            this.grpRefactorResults.Padding = new System.Windows.Forms.Padding(14, 10, 14, 14);
            this.grpRefactorResults.Size = new System.Drawing.Size(388, 339);
            this.grpRefactorResults.TabIndex = 0;
            this.grpRefactorResults.TabStop = false;
            this.grpRefactorResults.Text = "Refactor Results";
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(14, 25);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(360, 300);
            this.txtResults.TabIndex = 0;
            this.txtResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResults_KeyDown);
            // 
            // SpriteRefactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpriteRefactorForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Refactor Sprite Enumeration IDs";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpRefactorResults.ResumeLayout(false);
            this.grpRefactorResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRefactor;
        private System.Windows.Forms.GroupBox grpRefactorResults;
        private System.Windows.Forms.TextBox txtResults;
    }
}
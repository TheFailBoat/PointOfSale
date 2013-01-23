namespace PointOfSale.UI.Controls
{
    partial class BillControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BillDetailsList = new System.Windows.Forms.ListBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SettleButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.BillLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BillDetailsList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CloseButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SettleButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PrintButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 709);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BillDetailsList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BillDetailsList, 2);
            this.BillDetailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillDetailsList.FormattingEnabled = true;
            this.BillDetailsList.Location = new System.Drawing.Point(3, 78);
            this.BillDetailsList.Name = "BillDetailsList";
            this.BillDetailsList.Size = new System.Drawing.Size(478, 437);
            this.BillDetailsList.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CloseButton, 2);
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.Location = new System.Drawing.Point(3, 521);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(478, 89);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // SettleButton
            // 
            this.SettleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettleButton.Location = new System.Drawing.Point(3, 616);
            this.SettleButton.Name = "SettleButton";
            this.SettleButton.Size = new System.Drawing.Size(236, 90);
            this.SettleButton.TabIndex = 2;
            this.SettleButton.Text = "Settle";
            this.SettleButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintButton.Location = new System.Drawing.Point(245, 616);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(236, 90);
            this.PrintButton.TabIndex = 3;
            this.PrintButton.Text = "Print Bill";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.TableLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TimeLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BillLabel, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 69);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLabel.Location = new System.Drawing.Point(3, 0);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(153, 69);
            this.TableLabel.TabIndex = 0;
            this.TableLabel.Text = "Table #";
            this.TableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLabel.Location = new System.Drawing.Point(162, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(153, 69);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BillLabel
            // 
            this.BillLabel.AutoSize = true;
            this.BillLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillLabel.Location = new System.Drawing.Point(321, 0);
            this.BillLabel.Name = "BillLabel";
            this.BillLabel.Size = new System.Drawing.Size(154, 69);
            this.BillLabel.TabIndex = 2;
            this.BillLabel.Text = "Bill #";
            this.BillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BillControl";
            this.Size = new System.Drawing.Size(484, 709);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox BillDetailsList;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SettleButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label BillLabel;
    }
}

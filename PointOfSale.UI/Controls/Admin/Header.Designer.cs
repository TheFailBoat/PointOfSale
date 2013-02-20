namespace PointOfSale.UI.Controls.Admin
{
    partial class Header
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.ServerLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TimeLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.UserLabel, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 84);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerLabel.Location = new System.Drawing.Point(3, 0);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(153, 84);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Connected To: None";
            this.ServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLabel.Location = new System.Drawing.Point(162, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(153, 84);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLabel.Location = new System.Drawing.Point(321, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(154, 84);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Connected As: User";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(484, 90);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label UserLabel;
    }
}

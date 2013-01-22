namespace PointOfSale.UI
{
    partial class MainEntryForm
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
            this.navigationPanel1 = new PointOfSale.UI.Controls.NavigationPanel();
            this.billControl1 = new PointOfSale.UI.Controls.BillControl();
            this.mainPage1 = new PointOfSale.UI.Pages.MainPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.navigationPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.billControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainPage1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // navigationPanel1
            // 
            this.navigationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanel1.Location = new System.Drawing.Point(3, 3);
            this.navigationPanel1.Name = "navigationPanel1";
            this.navigationPanel1.Size = new System.Drawing.Size(498, 69);
            this.navigationPanel1.TabIndex = 0;
            // 
            // billControl1
            // 
            this.billControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billControl1.Location = new System.Drawing.Point(507, 3);
            this.billControl1.Name = "billControl1";
            this.tableLayoutPanel1.SetRowSpan(this.billControl1, 2);
            this.billControl1.Size = new System.Drawing.Size(498, 723);
            this.billControl1.TabIndex = 1;
            // 
            // mainPage1
            // 
            this.mainPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPage1.Location = new System.Drawing.Point(3, 78);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(498, 648);
            this.mainPage1.TabIndex = 2;
            // 
            // MainEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainEntryForm";
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.NavigationPanel navigationPanel1;
        private Controls.BillControl billControl1;
        private Pages.MainPage mainPage1;
    }
}


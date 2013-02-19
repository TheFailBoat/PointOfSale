namespace PointOfSale.Client.Pages
{
    partial class AdminPage
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
            this.itemSelectPanel1 = new PointOfSale.UI.Controls.ActionSelectPanel();
            this.valueInputPanel1 = new PointOfSale.UI.Controls.ValueInputPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.itemSelectPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueInputPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 481);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // itemSelectPanel1
            // 
            this.itemSelectPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemSelectPanel1.Location = new System.Drawing.Point(3, 3);
            this.itemSelectPanel1.Name = "itemSelectPanel1";
            this.itemSelectPanel1.Size = new System.Drawing.Size(466, 354);
            this.itemSelectPanel1.TabIndex = 1;
            // 
            // valueInputPanel1
            // 
            this.valueInputPanel1.Location = new System.Drawing.Point(3, 363);
            this.valueInputPanel1.Name = "valueInputPanel1";
            this.valueInputPanel1.Size = new System.Drawing.Size(466, 115);
            this.valueInputPanel1.TabIndex = 2;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(472, 481);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PointOfSale.UI.Controls.ActionSelectPanel itemSelectPanel1;
        private PointOfSale.UI.Controls.ValueInputPanel valueInputPanel1;
    }
}

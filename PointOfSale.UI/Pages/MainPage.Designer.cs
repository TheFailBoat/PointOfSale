namespace PointOfSale.UI.Pages
{
    partial class MainPage
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
            this.quantityInputPanel1 = new PointOfSale.UI.Controls.QuantityInputPanel();
            this.itemSelectPanel1 = new PointOfSale.UI.Controls.ActionSelectPanel();
            this.itemSelectPanel2 = new PointOfSale.UI.Controls.ActionSelectPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.quantityInputPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.itemSelectPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemSelectPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // quantityInputPanel1
            // 
            this.quantityInputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityInputPanel1.Location = new System.Drawing.Point(123, 381);
            this.quantityInputPanel1.Name = "quantityInputPanel1";
            this.quantityInputPanel1.Size = new System.Drawing.Size(355, 120);
            this.quantityInputPanel1.TabIndex = 0;
            // 
            // itemSelectPanel1
            // 
            this.itemSelectPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemSelectPanel1.Location = new System.Drawing.Point(123, 3);
            this.itemSelectPanel1.Name = "itemSelectPanel1";
            this.itemSelectPanel1.Size = new System.Drawing.Size(355, 372);
            this.itemSelectPanel1.TabIndex = 1;
            // 
            // itemSelectPanel2
            // 
            this.itemSelectPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemSelectPanel2.Location = new System.Drawing.Point(3, 3);
            this.itemSelectPanel2.Name = "itemSelectPanel2";
            this.tableLayoutPanel1.SetRowSpan(this.itemSelectPanel2, 2);
            this.itemSelectPanel2.Size = new System.Drawing.Size(114, 498);
            this.itemSelectPanel2.TabIndex = 2;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(481, 504);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.QuantityInputPanel quantityInputPanel1;
        private Controls.ActionSelectPanel itemSelectPanel1;
        private Controls.ActionSelectPanel itemSelectPanel2;
    }
}

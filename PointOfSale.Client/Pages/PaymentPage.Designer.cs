namespace PointOfSale.Client.Pages
{
    partial class PaymentPage
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
            this.itemSelectPanel2 = new PointOfSale.UI.Controls.ActionSelectPanel();
            this.quantityInputPanel1 = new PointOfSale.UI.Controls.QuantityInputPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.itemSelectPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemSelectPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.quantityInputPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 512);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // itemSelectPanel1
            // 
            this.itemSelectPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemSelectPanel1.Location = new System.Drawing.Point(3, 3);
            this.itemSelectPanel1.Name = "itemSelectPanel1";
            this.itemSelectPanel1.Size = new System.Drawing.Size(474, 250);
            this.itemSelectPanel1.TabIndex = 0;
            // 
            // itemSelectPanel2
            // 
            this.itemSelectPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemSelectPanel2.Location = new System.Drawing.Point(3, 259);
            this.itemSelectPanel2.Name = "itemSelectPanel2";
            this.itemSelectPanel2.Size = new System.Drawing.Size(474, 96);
            this.itemSelectPanel2.TabIndex = 1;
            // 
            // quantityInputPanel1
            // 
            this.quantityInputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityInputPanel1.Location = new System.Drawing.Point(3, 361);
            this.quantityInputPanel1.Name = "quantityInputPanel1";
            this.quantityInputPanel1.Size = new System.Drawing.Size(474, 148);
            this.quantityInputPanel1.TabIndex = 2;
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaymentPage";
            this.Size = new System.Drawing.Size(480, 512);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PointOfSale.UI.Controls.ActionSelectPanel itemSelectPanel1;
        private PointOfSale.UI.Controls.ActionSelectPanel itemSelectPanel2;
        private PointOfSale.UI.Controls.QuantityInputPanel quantityInputPanel1;
    }
}

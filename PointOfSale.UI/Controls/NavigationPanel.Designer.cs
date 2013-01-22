namespace PointOfSale.UI.Controls
{
    partial class NavigationPanel
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminButton.Location = new System.Drawing.Point(291, 3);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(140, 69);
            this.AdminButton.TabIndex = 8;
            this.AdminButton.Text = "Admin Functions";
            this.AdminButton.UseVisualStyleBackColor = true;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNoteButton.Location = new System.Drawing.Point(147, 3);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(138, 69);
            this.AddNoteButton.TabIndex = 7;
            this.AddNoteButton.Text = "Add Note";
            this.AddNoteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteItemButton.Location = new System.Drawing.Point(3, 3);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(138, 69);
            this.DeleteItemButton.TabIndex = 6;
            this.DeleteItemButton.Text = "Delete Item";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.DeleteItemButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddNoteButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 75);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // NavigationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NavigationPanel";
            this.Size = new System.Drawing.Size(434, 75);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button AdminButton;
        internal System.Windows.Forms.Button AddNoteButton;
        internal System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}

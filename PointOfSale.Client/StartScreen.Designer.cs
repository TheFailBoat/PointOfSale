namespace PointOfSale.Client
{
    partial class StartScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.startPOSButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startAdmin);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.startPOSButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 308);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 70);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(3, 152);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(194, 70);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // startPOSButton
            // 
            this.startPOSButton.Location = new System.Drawing.Point(3, 0);
            this.startPOSButton.Name = "startPOSButton";
            this.startPOSButton.Size = new System.Drawing.Size(194, 70);
            this.startPOSButton.TabIndex = 0;
            this.startPOSButton.Text = "Start POS";
            this.startPOSButton.UseVisualStyleBackColor = true;
            this.startPOSButton.Click += new System.EventHandler(this.startPOSButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PointOfSale.Client.Properties.Resources.photo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 298);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // startAdmin
            // 
            this.startAdmin.Location = new System.Drawing.Point(3, 76);
            this.startAdmin.Name = "startAdmin";
            this.startAdmin.Size = new System.Drawing.Size(194, 70);
            this.startAdmin.TabIndex = 4;
            this.startAdmin.Text = "Start Admin Program";
            this.startAdmin.UseVisualStyleBackColor = true;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button startPOSButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startAdmin;

    }
}
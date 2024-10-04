namespace LumiaFixer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lumiaFixerHeading = new System.Windows.Forms.Label();
            this.lumiaFixerInstructions = new System.Windows.Forms.Label();
            this.getStartedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lumiaFixerHeading
            // 
            this.lumiaFixerHeading.AutoSize = true;
            this.lumiaFixerHeading.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumiaFixerHeading.Location = new System.Drawing.Point(12, 9);
            this.lumiaFixerHeading.Name = "lumiaFixerHeading";
            this.lumiaFixerHeading.Size = new System.Drawing.Size(137, 40);
            this.lumiaFixerHeading.TabIndex = 0;
            this.lumiaFixerHeading.Text = "lumiafixer";
            // 
            // lumiaFixerInstructions
            // 
            this.lumiaFixerInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lumiaFixerInstructions.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumiaFixerInstructions.Location = new System.Drawing.Point(16, 49);
            this.lumiaFixerInstructions.Name = "lumiaFixerInstructions";
            this.lumiaFixerInstructions.Size = new System.Drawing.Size(675, 99);
            this.lumiaFixerInstructions.TabIndex = 1;
            this.lumiaFixerInstructions.Text = resources.GetString("lumiaFixerInstructions.Text");
            // 
            // getStartedButton
            // 
            this.getStartedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getStartedButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStartedButton.Location = new System.Drawing.Point(19, 151);
            this.getStartedButton.Name = "getStartedButton";
            this.getStartedButton.Size = new System.Drawing.Size(93, 37);
            this.getStartedButton.TabIndex = 2;
            this.getStartedButton.Text = "get started";
            this.getStartedButton.UseVisualStyleBackColor = true;
            this.getStartedButton.Click += new System.EventHandler(this.getStartedButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 205);
            this.Controls.Add(this.getStartedButton);
            this.Controls.Add(this.lumiaFixerInstructions);
            this.Controls.Add(this.lumiaFixerHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 244);
            this.MinimumSize = new System.Drawing.Size(719, 244);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LumiaFixer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lumiaFixerHeading;
        private System.Windows.Forms.Label lumiaFixerInstructions;
        private System.Windows.Forms.Button getStartedButton;
    }
}


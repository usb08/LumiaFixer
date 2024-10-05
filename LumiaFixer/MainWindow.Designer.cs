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
            lumiaFixerHeading = new System.Windows.Forms.Label();
            lumiaFixerInstructions = new System.Windows.Forms.Label();
            getStartedButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lumiaFixerHeading
            // 
            lumiaFixerHeading.AutoSize = true;
            lumiaFixerHeading.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lumiaFixerHeading.Location = new System.Drawing.Point(14, 10);
            lumiaFixerHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lumiaFixerHeading.Name = "lumiaFixerHeading";
            lumiaFixerHeading.Size = new System.Drawing.Size(137, 40);
            lumiaFixerHeading.TabIndex = 0;
            lumiaFixerHeading.Text = "lumiafixer";
            // 
            // lumiaFixerInstructions
            // 
            lumiaFixerInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lumiaFixerInstructions.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lumiaFixerInstructions.Location = new System.Drawing.Point(19, 60);
            lumiaFixerInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lumiaFixerInstructions.Name = "lumiaFixerInstructions";
            lumiaFixerInstructions.Size = new System.Drawing.Size(788, 111);
            lumiaFixerInstructions.TabIndex = 1;
            lumiaFixerInstructions.Text = resources.GetString("lumiaFixerInstructions.Text");
            // 
            // getStartedButton
            // 
            getStartedButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            getStartedButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            getStartedButton.Location = new System.Drawing.Point(22, 174);
            getStartedButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            getStartedButton.Name = "getStartedButton";
            getStartedButton.Size = new System.Drawing.Size(108, 43);
            getStartedButton.TabIndex = 2;
            getStartedButton.Text = "get started";
            getStartedButton.UseVisualStyleBackColor = true;
            getStartedButton.Click += getStartedButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(820, 237);
            Controls.Add(getStartedButton);
            Controls.Add(lumiaFixerInstructions);
            Controls.Add(lumiaFixerHeading);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(836, 276);
            MinimumSize = new System.Drawing.Size(836, 276);
            Name = "MainWindow";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LumiaFixer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lumiaFixerHeading;
        private System.Windows.Forms.Label lumiaFixerInstructions;
        private System.Windows.Forms.Button getStartedButton;
    }
}


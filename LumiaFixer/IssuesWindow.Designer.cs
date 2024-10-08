namespace LumiaFixer
{
    partial class IssuesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuesWindow));
            lumiaFixerHeading = new System.Windows.Forms.Label();
            lumiaFixerInstructions = new System.Windows.Forms.Label();
            redirectButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lumiaFixerHeading
            // 
            lumiaFixerHeading.AutoSize = true;
            lumiaFixerHeading.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lumiaFixerHeading.Location = new System.Drawing.Point(7, 7);
            lumiaFixerHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lumiaFixerHeading.Name = "lumiaFixerHeading";
            lumiaFixerHeading.Size = new System.Drawing.Size(137, 40);
            lumiaFixerHeading.TabIndex = 1;
            lumiaFixerHeading.Text = "lumiafixer";
            // 
            // lumiaFixerInstructions
            // 
            lumiaFixerInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lumiaFixerInstructions.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lumiaFixerInstructions.Location = new System.Drawing.Point(12, 47);
            lumiaFixerInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lumiaFixerInstructions.Name = "lumiaFixerInstructions";
            lumiaFixerInstructions.Size = new System.Drawing.Size(347, 33);
            lumiaFixerInstructions.TabIndex = 3;
            lumiaFixerInstructions.Text = "the list of known issues is available in the GitHub readme, click the button below to be redirected.";
            // 
            // redirectButton
            // 
            redirectButton.Location = new System.Drawing.Point(12, 83);
            redirectButton.Name = "redirectButton";
            redirectButton.Size = new System.Drawing.Size(354, 40);
            redirectButton.TabIndex = 4;
            redirectButton.Text = "Go to GitHub";
            redirectButton.UseVisualStyleBackColor = true;
            redirectButton.Click += redirectButton_Click;
            // 
            // IssuesWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(378, 139);
            Controls.Add(redirectButton);
            Controls.Add(lumiaFixerInstructions);
            Controls.Add(lumiaFixerHeading);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(394, 178);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(394, 178);
            Name = "IssuesWindow";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LumiaFixer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lumiaFixerHeading;
        private System.Windows.Forms.Label lumiaFixerInstructions;
        private System.Windows.Forms.Button redirectButton;
    }
}
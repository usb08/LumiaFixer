namespace LumiaFixer
{
    partial class UnbrickWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnbrickWindow));
            this.lumiaFixerHeading = new System.Windows.Forms.Label();
            this.lumiaFixerInstructions = new System.Windows.Forms.Label();
            this.openEDEButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openEDPButton = new System.Windows.Forms.Button();
            this.EDEPathLabel = new System.Windows.Forms.Label();
            this.EDPPathLabel = new System.Windows.Forms.Label();
            this.FFUPathLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFFUButton = new System.Windows.Forms.Button();
            this.lumiaFixerDisclaimer = new System.Windows.Forms.Label();
            this.startRecoveryButton = new System.Windows.Forms.Button();
            this.WDRTPathLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openWDRTButton = new System.Windows.Forms.Button();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.faqButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lumiaFixerHeading
            // 
            this.lumiaFixerHeading.AutoSize = true;
            this.lumiaFixerHeading.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumiaFixerHeading.Location = new System.Drawing.Point(12, 9);
            this.lumiaFixerHeading.Name = "lumiaFixerHeading";
            this.lumiaFixerHeading.Size = new System.Drawing.Size(137, 40);
            this.lumiaFixerHeading.TabIndex = 1;
            this.lumiaFixerHeading.Text = "lumiafixer";
            // 
            // lumiaFixerInstructions
            // 
            this.lumiaFixerInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lumiaFixerInstructions.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumiaFixerInstructions.Location = new System.Drawing.Point(16, 49);
            this.lumiaFixerInstructions.Name = "lumiaFixerInstructions";
            this.lumiaFixerInstructions.Size = new System.Drawing.Size(740, 35);
            this.lumiaFixerInstructions.TabIndex = 2;
            this.lumiaFixerInstructions.Text = resources.GetString("lumiaFixerInstructions.Text");
            // 
            // openEDEButton
            // 
            this.openEDEButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openEDEButton.Location = new System.Drawing.Point(19, 161);
            this.openEDEButton.Name = "openEDEButton";
            this.openEDEButton.Size = new System.Drawing.Size(107, 26);
            this.openEDEButton.TabIndex = 3;
            this.openEDEButton.Text = "open EDE file";
            this.openEDEButton.UseVisualStyleBackColor = true;
            this.openEDEButton.Click += new System.EventHandler(this.openEDEButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "emergency files:";
            // 
            // openEDPButton
            // 
            this.openEDPButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openEDPButton.Location = new System.Drawing.Point(19, 193);
            this.openEDPButton.Name = "openEDPButton";
            this.openEDPButton.Size = new System.Drawing.Size(107, 26);
            this.openEDPButton.TabIndex = 5;
            this.openEDPButton.Text = "open EDP file";
            this.openEDPButton.UseVisualStyleBackColor = true;
            this.openEDPButton.Click += new System.EventHandler(this.openEDPButton_Click);
            // 
            // EDEPathLabel
            // 
            this.EDEPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EDEPathLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDEPathLabel.Location = new System.Drawing.Point(132, 161);
            this.EDEPathLabel.Name = "EDEPathLabel";
            this.EDEPathLabel.Size = new System.Drawing.Size(624, 26);
            this.EDEPathLabel.TabIndex = 6;
            this.EDEPathLabel.Text = "none selected";
            this.EDEPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EDPPathLabel
            // 
            this.EDPPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EDPPathLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDPPathLabel.Location = new System.Drawing.Point(132, 193);
            this.EDPPathLabel.Name = "EDPPathLabel";
            this.EDPPathLabel.Size = new System.Drawing.Size(624, 26);
            this.EDPPathLabel.TabIndex = 7;
            this.EDPPathLabel.Text = "none selected";
            this.EDPPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FFUPathLabel
            // 
            this.FFUPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FFUPathLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FFUPathLabel.Location = new System.Drawing.Point(132, 251);
            this.FFUPathLabel.Name = "FFUPathLabel";
            this.FFUPathLabel.Size = new System.Drawing.Size(624, 26);
            this.FFUPathLabel.TabIndex = 11;
            this.FFUPathLabel.Text = "none selected";
            this.FFUPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "firmware:";
            // 
            // openFFUButton
            // 
            this.openFFUButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFFUButton.Location = new System.Drawing.Point(19, 251);
            this.openFFUButton.Name = "openFFUButton";
            this.openFFUButton.Size = new System.Drawing.Size(107, 26);
            this.openFFUButton.TabIndex = 8;
            this.openFFUButton.Text = "open FFU file";
            this.openFFUButton.UseVisualStyleBackColor = true;
            this.openFFUButton.Click += new System.EventHandler(this.openFFUButton_Click);
            // 
            // lumiaFixerDisclaimer
            // 
            this.lumiaFixerDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lumiaFixerDisclaimer.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumiaFixerDisclaimer.Location = new System.Drawing.Point(16, 294);
            this.lumiaFixerDisclaimer.Name = "lumiaFixerDisclaimer";
            this.lumiaFixerDisclaimer.Size = new System.Drawing.Size(740, 34);
            this.lumiaFixerDisclaimer.TabIndex = 12;
            this.lumiaFixerDisclaimer.Text = "please note that this process will erase all of your data, your phone will be fla" +
    "shed again which means it\'ll have none of your data on it, by clicking the butto" +
    "n below you acknowledge this";
            // 
            // startRecoveryButton
            // 
            this.startRecoveryButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRecoveryButton.Location = new System.Drawing.Point(19, 331);
            this.startRecoveryButton.Name = "startRecoveryButton";
            this.startRecoveryButton.Size = new System.Drawing.Size(130, 38);
            this.startRecoveryButton.TabIndex = 13;
            this.startRecoveryButton.Text = "start recovery";
            this.startRecoveryButton.UseVisualStyleBackColor = true;
            // 
            // WDRTPathLabel
            // 
            this.WDRTPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WDRTPathLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WDRTPathLabel.Location = new System.Drawing.Point(132, 107);
            this.WDRTPathLabel.Name = "WDRTPathLabel";
            this.WDRTPathLabel.Size = new System.Drawing.Size(624, 26);
            this.WDRTPathLabel.TabIndex = 16;
            this.WDRTPathLabel.Text = "none selected";
            this.WDRTPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "wdrt (windows device recovery tool) path/folder:";
            // 
            // openWDRTButton
            // 
            this.openWDRTButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openWDRTButton.Location = new System.Drawing.Point(19, 107);
            this.openWDRTButton.Name = "openWDRTButton";
            this.openWDRTButton.Size = new System.Drawing.Size(107, 26);
            this.openWDRTButton.TabIndex = 14;
            this.openWDRTButton.Text = "open WDRT path";
            this.openWDRTButton.UseVisualStyleBackColor = true;
            this.openWDRTButton.Click += new System.EventHandler(this.openWDRTButton_Click);
            // 
            // consoleOutput
            // 
            this.consoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleOutput.BackColor = System.Drawing.Color.Black;
            this.consoleOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleOutput.ForeColor = System.Drawing.Color.White;
            this.consoleOutput.Location = new System.Drawing.Point(19, 375);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.Size = new System.Drawing.Size(737, 112);
            this.consoleOutput.TabIndex = 17;
            this.consoleOutput.Text = "console output will be shown here";
            // 
            // faqButton
            // 
            this.faqButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faqButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faqButton.Location = new System.Drawing.Point(608, 331);
            this.faqButton.Name = "faqButton";
            this.faqButton.Size = new System.Drawing.Size(148, 38);
            this.faqButton.TabIndex = 18;
            this.faqButton.Text = "i have an issue";
            this.faqButton.UseVisualStyleBackColor = true;
            // 
            // UnbrickWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 499);
            this.Controls.Add(this.faqButton);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.WDRTPathLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.openWDRTButton);
            this.Controls.Add(this.startRecoveryButton);
            this.Controls.Add(this.lumiaFixerDisclaimer);
            this.Controls.Add(this.FFUPathLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.openFFUButton);
            this.Controls.Add(this.EDPPathLabel);
            this.Controls.Add(this.EDEPathLabel);
            this.Controls.Add(this.openEDPButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openEDEButton);
            this.Controls.Add(this.lumiaFixerInstructions);
            this.Controls.Add(this.lumiaFixerHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(784, 538);
            this.Name = "UnbrickWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LumiaFixer";
            this.Load += new System.EventHandler(this.UnbrickWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lumiaFixerHeading;
        private System.Windows.Forms.Label lumiaFixerInstructions;
        private System.Windows.Forms.Button openEDEButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openEDPButton;
        private System.Windows.Forms.Label EDEPathLabel;
        private System.Windows.Forms.Label EDPPathLabel;
        private System.Windows.Forms.Label FFUPathLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openFFUButton;
        private System.Windows.Forms.Label lumiaFixerDisclaimer;
        private System.Windows.Forms.Button startRecoveryButton;
        private System.Windows.Forms.Label WDRTPathLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button openWDRTButton;
        private System.Windows.Forms.RichTextBox consoleOutput;
        private System.Windows.Forms.Button faqButton;
    }
}
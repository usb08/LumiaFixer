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
            lumiaFixerHeading = new System.Windows.Forms.Label();
            lumiaFixerInstructions = new System.Windows.Forms.Label();
            openEDEButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            openEDPButton = new System.Windows.Forms.Button();
            EDEPathLabel = new System.Windows.Forms.Label();
            EDPPathLabel = new System.Windows.Forms.Label();
            FFUPathLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            openFFUButton = new System.Windows.Forms.Button();
            lumiaFixerDisclaimer = new System.Windows.Forms.Label();
            startRecoveryButton = new System.Windows.Forms.Button();
            WDRTPathLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            openWDRTButton = new System.Windows.Forms.Button();
            consoleOutput = new System.Windows.Forms.RichTextBox();
            faqButton = new System.Windows.Forms.Button();
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
            lumiaFixerHeading.TabIndex = 1;
            lumiaFixerHeading.Text = "lumiafixer";
            // 
            // lumiaFixerInstructions
            // 
            lumiaFixerInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lumiaFixerInstructions.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lumiaFixerInstructions.Location = new System.Drawing.Point(19, 57);
            lumiaFixerInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lumiaFixerInstructions.Name = "lumiaFixerInstructions";
            lumiaFixerInstructions.Size = new System.Drawing.Size(863, 40);
            lumiaFixerInstructions.TabIndex = 2;
            lumiaFixerInstructions.Text = resources.GetString("lumiaFixerInstructions.Text");
            // 
            // openEDEButton
            // 
            openEDEButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            openEDEButton.Location = new System.Drawing.Point(22, 188);
            openEDEButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openEDEButton.Name = "openEDEButton";
            openEDEButton.Size = new System.Drawing.Size(125, 30);
            openEDEButton.TabIndex = 3;
            openEDEButton.Text = "open EDE file";
            openEDEButton.UseVisualStyleBackColor = true;
            openEDEButton.Click += openEDEButton_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(19, 167);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 15);
            label1.TabIndex = 4;
            label1.Text = "emergency files:";
            // 
            // openEDPButton
            // 
            openEDPButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            openEDPButton.Location = new System.Drawing.Point(22, 225);
            openEDPButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openEDPButton.Name = "openEDPButton";
            openEDPButton.Size = new System.Drawing.Size(125, 30);
            openEDPButton.TabIndex = 5;
            openEDPButton.Text = "open EDP file";
            openEDPButton.UseVisualStyleBackColor = true;
            openEDPButton.Click += openEDPButton_Click;
            // 
            // EDEPathLabel
            // 
            EDEPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            EDEPathLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EDEPathLabel.Location = new System.Drawing.Point(154, 188);
            EDEPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            EDEPathLabel.Name = "EDEPathLabel";
            EDEPathLabel.Size = new System.Drawing.Size(728, 30);
            EDEPathLabel.TabIndex = 6;
            EDEPathLabel.Text = "none selected";
            EDEPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EDPPathLabel
            // 
            EDPPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            EDPPathLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EDPPathLabel.Location = new System.Drawing.Point(154, 225);
            EDPPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            EDPPathLabel.Name = "EDPPathLabel";
            EDPPathLabel.Size = new System.Drawing.Size(728, 30);
            EDPPathLabel.TabIndex = 7;
            EDPPathLabel.Text = "none selected";
            EDPPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FFUPathLabel
            // 
            FFUPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            FFUPathLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FFUPathLabel.Location = new System.Drawing.Point(154, 290);
            FFUPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            FFUPathLabel.Name = "FFUPathLabel";
            FFUPathLabel.Size = new System.Drawing.Size(728, 30);
            FFUPathLabel.TabIndex = 11;
            FFUPathLabel.Text = "none selected";
            FFUPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(19, 269);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 15);
            label6.TabIndex = 9;
            label6.Text = "firmware:";
            // 
            // openFFUButton
            // 
            openFFUButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            openFFUButton.Location = new System.Drawing.Point(22, 290);
            openFFUButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openFFUButton.Name = "openFFUButton";
            openFFUButton.Size = new System.Drawing.Size(125, 30);
            openFFUButton.TabIndex = 8;
            openFFUButton.Text = "open FFU file";
            openFFUButton.UseVisualStyleBackColor = true;
            openFFUButton.Click += openFFUButton_Click;
            // 
            // lumiaFixerDisclaimer
            // 
            lumiaFixerDisclaimer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lumiaFixerDisclaimer.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lumiaFixerDisclaimer.Location = new System.Drawing.Point(19, 339);
            lumiaFixerDisclaimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lumiaFixerDisclaimer.Name = "lumiaFixerDisclaimer";
            lumiaFixerDisclaimer.Size = new System.Drawing.Size(863, 39);
            lumiaFixerDisclaimer.TabIndex = 12;
            lumiaFixerDisclaimer.Text = "please note that this process will erase all of your data, your phone will be flashed again which means it'll have none of your data on it, by clicking the button below you acknowledge this";
            // 
            // startRecoveryButton
            // 
            startRecoveryButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            startRecoveryButton.Location = new System.Drawing.Point(22, 382);
            startRecoveryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            startRecoveryButton.Name = "startRecoveryButton";
            startRecoveryButton.Size = new System.Drawing.Size(152, 44);
            startRecoveryButton.TabIndex = 13;
            startRecoveryButton.Text = "start recovery";
            startRecoveryButton.UseVisualStyleBackColor = true;
            startRecoveryButton.Click += startRecoveryButton_Click;
            // 
            // WDRTPathLabel
            // 
            WDRTPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            WDRTPathLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            WDRTPathLabel.Location = new System.Drawing.Point(154, 123);
            WDRTPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            WDRTPathLabel.Name = "WDRTPathLabel";
            WDRTPathLabel.Size = new System.Drawing.Size(728, 30);
            WDRTPathLabel.TabIndex = 16;
            WDRTPathLabel.Text = "none selected";
            WDRTPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(19, 103);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(259, 15);
            label8.TabIndex = 15;
            label8.Text = "wdrt (windows device recovery tool) path/folder:";
            // 
            // openWDRTButton
            // 
            openWDRTButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            openWDRTButton.Location = new System.Drawing.Point(22, 123);
            openWDRTButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openWDRTButton.Name = "openWDRTButton";
            openWDRTButton.Size = new System.Drawing.Size(125, 30);
            openWDRTButton.TabIndex = 14;
            openWDRTButton.Text = "open WDRT path";
            openWDRTButton.UseVisualStyleBackColor = true;
            openWDRTButton.Click += openWDRTButton_Click;
            // 
            // consoleOutput
            // 
            consoleOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            consoleOutput.BackColor = System.Drawing.Color.Black;
            consoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            consoleOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            consoleOutput.ForeColor = System.Drawing.Color.White;
            consoleOutput.Location = new System.Drawing.Point(22, 433);
            consoleOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            consoleOutput.Name = "consoleOutput";
            consoleOutput.ReadOnly = true;
            consoleOutput.Size = new System.Drawing.Size(859, 129);
            consoleOutput.TabIndex = 17;
            consoleOutput.Text = "";
            // 
            // faqButton
            // 
            faqButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            faqButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            faqButton.Location = new System.Drawing.Point(708, 382);
            faqButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            faqButton.Name = "faqButton";
            faqButton.Size = new System.Drawing.Size(173, 44);
            faqButton.TabIndex = 18;
            faqButton.Text = "i have an issue";
            faqButton.UseVisualStyleBackColor = true;
            faqButton.Click += faqButton_Click;
            // 
            // UnbrickWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(896, 576);
            Controls.Add(faqButton);
            Controls.Add(consoleOutput);
            Controls.Add(WDRTPathLabel);
            Controls.Add(label8);
            Controls.Add(openWDRTButton);
            Controls.Add(startRecoveryButton);
            Controls.Add(lumiaFixerDisclaimer);
            Controls.Add(FFUPathLabel);
            Controls.Add(label6);
            Controls.Add(openFFUButton);
            Controls.Add(EDPPathLabel);
            Controls.Add(EDEPathLabel);
            Controls.Add(openEDPButton);
            Controls.Add(label1);
            Controls.Add(openEDEButton);
            Controls.Add(lumiaFixerInstructions);
            Controls.Add(lumiaFixerHeading);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(912, 615);
            Name = "UnbrickWindow";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LumiaFixer";
            ResumeLayout(false);
            PerformLayout();
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
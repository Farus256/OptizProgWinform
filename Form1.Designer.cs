namespace OptizProgWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Win32PrioritySeparation = new Label();
            ResetWin32 = new Button();
            Win32PriorityButton = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // Win32PrioritySeparation
            // 
            Win32PrioritySeparation.AutoSize = true;
            Win32PrioritySeparation.FlatStyle = FlatStyle.System;
            Win32PrioritySeparation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Win32PrioritySeparation.Location = new Point(12, 52);
            Win32PrioritySeparation.Name = "Win32PrioritySeparation";
            Win32PrioritySeparation.Size = new Size(159, 17);
            Win32PrioritySeparation.TabIndex = 2;
            Win32PrioritySeparation.Text = "Win32PrioritySeparation";
            // 
            // ResetWin32
            // 
            ResetWin32.Location = new Point(356, 83);
            ResetWin32.Name = "ResetWin32";
            ResetWin32.Size = new Size(75, 23);
            ResetWin32.TabIndex = 3;
            ResetWin32.Text = "Reset";
            ResetWin32.UseVisualStyleBackColor = true;
            ResetWin32.Click += ResetWin32_Click;
            // 
            // Win32PriorityButton
            // 
            Win32PriorityButton.Location = new Point(12, 72);
            Win32PriorityButton.Name = "Win32PriorityButton";
            Win32PriorityButton.Size = new Size(80, 43);
            Win32PriorityButton.TabIndex = 4;
            Win32PriorityButton.Text = "Change";
            Win32PriorityButton.UseVisualStyleBackColor = true;
            Win32PriorityButton.Click += Win32PriorityButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 83);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 5;
            label1.Text = "None";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(105, 23);
            comboBox1.TabIndex = 6;
            comboBox1.KeyPress += ComboBox1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(443, 302);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(Win32PriorityButton);
            Controls.Add(ResetWin32);
            Controls.Add(Win32PrioritySeparation);
            Cursor = Cursors.Default;
            Name = "Form1";
            Text = "OptizProg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Win32PrioritySeparation;
        private Button ResetWin32;
        private Button Win32PriorityButton;
        private Label label1;
        private ComboBox comboBox1;
    }
}
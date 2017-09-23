namespace Win10_Keyboard_Resizer
{
    partial class MainForm
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
            this.KeyboardScaleBar = new System.Windows.Forms.TrackBar();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.KeyboardScale = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardScaleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardScale)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyboardScaleBar
            // 
            this.KeyboardScaleBar.Location = new System.Drawing.Point(12, 40);
            this.KeyboardScaleBar.Maximum = 100;
            this.KeyboardScaleBar.Name = "KeyboardScaleBar";
            this.KeyboardScaleBar.Size = new System.Drawing.Size(349, 45);
            this.KeyboardScaleBar.SmallChange = 5;
            this.KeyboardScaleBar.TabIndex = 0;
            this.KeyboardScaleBar.TickFrequency = 5;
            this.KeyboardScaleBar.Scroll += new System.EventHandler(this.KeyboardScaleBar_Scroll);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(137, 105);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(338, 42);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keyboard Scale";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(12, 105);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(119, 42);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // KeyboardScale
            // 
            this.KeyboardScale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyboardScale.Location = new System.Drawing.Point(367, 40);
            this.KeyboardScale.Name = "KeyboardScale";
            this.KeyboardScale.Size = new System.Drawing.Size(108, 29);
            this.KeyboardScale.TabIndex = 5;
            this.KeyboardScale.ValueChanged += new System.EventHandler(this.KeyboardScale_ValueChanged);
            this.KeyboardScale.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyboardScale_KeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 159);
            this.Controls.Add(this.KeyboardScale);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.KeyboardScaleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Windows 10 Keyboard Resizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardScaleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar KeyboardScaleBar;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.NumericUpDown KeyboardScale;
    }
}


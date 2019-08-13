namespace ezClock
{
    partial class Form_ezClock
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
            this.label_ezClock = new System.Windows.Forms.Label();
            this.button_Clock = new System.Windows.Forms.Button();
            this.listBox_ClockEntries = new System.Windows.Forms.ListBox();
            this.label_Slogan = new System.Windows.Forms.Label();
            this.button_Import = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ezClock
            // 
            this.label_ezClock.AutoSize = true;
            this.label_ezClock.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ezClock.Location = new System.Drawing.Point(12, 9);
            this.label_ezClock.Name = "label_ezClock";
            this.label_ezClock.Size = new System.Drawing.Size(182, 76);
            this.label_ezClock.TabIndex = 0;
            this.label_ezClock.Text = "ezClock";
            // 
            // button_Clock
            // 
            this.button_Clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clock.Location = new System.Drawing.Point(697, 510);
            this.button_Clock.Name = "button_Clock";
            this.button_Clock.Size = new System.Drawing.Size(75, 40);
            this.button_Clock.TabIndex = 1;
            this.button_Clock.Text = "Clock!";
            this.button_Clock.UseVisualStyleBackColor = true;
            this.button_Clock.Click += new System.EventHandler(this.button_Clock_Click);
            // 
            // listBox_ClockEntries
            // 
            this.listBox_ClockEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_ClockEntries.FormattingEnabled = true;
            this.listBox_ClockEntries.Location = new System.Drawing.Point(12, 110);
            this.listBox_ClockEntries.Name = "listBox_ClockEntries";
            this.listBox_ClockEntries.Size = new System.Drawing.Size(760, 394);
            this.listBox_ClockEntries.TabIndex = 2;
            // 
            // label_Slogan
            // 
            this.label_Slogan.AutoSize = true;
            this.label_Slogan.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Slogan.Location = new System.Drawing.Point(22, 85);
            this.label_Slogan.Name = "label_Slogan";
            this.label_Slogan.Size = new System.Drawing.Size(165, 14);
            this.label_Slogan.TabIndex = 3;
            this.label_Slogan.Text = "Clocking hours made EZ.";
            // 
            // button_Import
            // 
            this.button_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Import.Location = new System.Drawing.Point(12, 510);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(75, 40);
            this.button_Import.TabIndex = 4;
            this.button_Import.Text = "Import...";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // button_Export
            // 
            this.button_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Export.Location = new System.Drawing.Point(93, 510);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(75, 40);
            this.button_Export.TabIndex = 5;
            this.button_Export.Text = "Export...";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // Form_ezClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.label_Slogan);
            this.Controls.Add(this.listBox_ClockEntries);
            this.Controls.Add(this.button_Clock);
            this.Controls.Add(this.label_ezClock);
            this.Name = "Form_ezClock";
            this.Text = "ezClock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ezClock_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ezClock;
        private System.Windows.Forms.Button button_Clock;
        private System.Windows.Forms.ListBox listBox_ClockEntries;
        private System.Windows.Forms.Label label_Slogan;
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.Button button_Export;
    }
}


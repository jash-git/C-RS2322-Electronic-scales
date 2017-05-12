namespace WriteDemo
{
    partial class Form1
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
            this.btnLED = new System.Windows.Forms.Button();
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLED
            // 
            this.btnLED.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLED.Enabled = false;
            this.btnLED.Location = new System.Drawing.Point(23, 59);
            this.btnLED.Name = "btnLED";
            this.btnLED.Size = new System.Drawing.Size(285, 109);
            this.btnLED.TabIndex = 0;
            this.btnLED.Text = "LED";
            this.btnLED.UseVisualStyleBackColor = false;
            this.btnLED.Click += new System.EventHandler(this.btnLED_Click);
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(23, 23);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(194, 20);
            this.cbSerialPorts.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(233, 21);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 189);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cbSerialPorts);
            this.Controls.Add(this.btnLED);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WriteDemo - Write Data to Serial Port";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLED;
        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Button btnOpen;
    }
}


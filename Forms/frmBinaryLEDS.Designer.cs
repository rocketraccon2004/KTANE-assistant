namespace KTANE_Assistant.Forms
{
    partial class frmBinaryLEDs
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
            btnLED5 = new System.Windows.Forms.Button();
            btnLED1 = new System.Windows.Forms.Button();
            btnLED2 = new System.Windows.Forms.Button();
            btnLED3 = new System.Windows.Forms.Button();
            btnLED4 = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(359, 226);
            btnBack.Size = new System.Drawing.Size(156, 63);
            // 
            // btnStrike
            // 
            btnStrike.Location = new System.Drawing.Point(199, 226);
            btnStrike.Size = new System.Drawing.Size(156, 63);
            // 
            // btnSolve
            // 
            btnSolve.Location = new System.Drawing.Point(39, 227);
            btnSolve.Size = new System.Drawing.Size(156, 63);
            btnSolve.Click += btnSolve_Click;
            // 
            // btnLED5
            // 
            btnLED5.BackColor = System.Drawing.Color.Red;
            btnLED5.Location = new System.Drawing.Point(39, 24);
            btnLED5.Name = "btnLED5";
            btnLED5.Size = new System.Drawing.Size(80, 18);
            btnLED5.TabIndex = 82;
            btnLED5.Text = "\r\n";
            btnLED5.UseVisualStyleBackColor = false;
            btnLED5.Click += ToggleLED;
            // 
            // btnLED1
            // 
            btnLED1.BackColor = System.Drawing.Color.Red;
            btnLED1.Location = new System.Drawing.Point(414, 24);
            btnLED1.Name = "btnLED1";
            btnLED1.Size = new System.Drawing.Size(80, 18);
            btnLED1.TabIndex = 83;
            btnLED1.Text = "\r\n";
            btnLED1.UseVisualStyleBackColor = false;
            btnLED1.Click += ToggleLED;
            // 
            // btnLED2
            // 
            btnLED2.BackColor = System.Drawing.Color.Red;
            btnLED2.Location = new System.Drawing.Point(328, 24);
            btnLED2.Name = "btnLED2";
            btnLED2.Size = new System.Drawing.Size(80, 18);
            btnLED2.TabIndex = 84;
            btnLED2.Text = "\r\n";
            btnLED2.UseVisualStyleBackColor = false;
            btnLED2.Click += ToggleLED;
            // 
            // btnLED3
            // 
            btnLED3.BackColor = System.Drawing.Color.Red;
            btnLED3.Location = new System.Drawing.Point(231, 24);
            btnLED3.Name = "btnLED3";
            btnLED3.Size = new System.Drawing.Size(80, 18);
            btnLED3.TabIndex = 85;
            btnLED3.Text = "\r\n";
            btnLED3.UseVisualStyleBackColor = false;
            btnLED3.Click += ToggleLED;
            // 
            // btnLED4
            // 
            btnLED4.BackColor = System.Drawing.Color.Red;
            btnLED4.Location = new System.Drawing.Point(136, 24);
            btnLED4.Name = "btnLED4";
            btnLED4.Size = new System.Drawing.Size(80, 18);
            btnLED4.TabIndex = 86;
            btnLED4.Text = "\r\n";
            btnLED4.UseVisualStyleBackColor = false;
            btnLED4.Click += ToggleLED;
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnReset.Location = new System.Drawing.Point(520, 226);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(156, 63);
            btnReset.TabIndex = 87;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmBinaryLEDs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(702, 311);
            Controls.Add(btnReset);
            Controls.Add(btnLED4);
            Controls.Add(btnLED3);
            Controls.Add(btnLED2);
            Controls.Add(btnLED1);
            Controls.Add(btnLED5);
            Text = "Binary LEDS";
            Load += frmBinaryLEDs_Load;
            Controls.SetChildIndex(btnLED5, 0);
            Controls.SetChildIndex(btnLED1, 0);
            Controls.SetChildIndex(btnLED2, 0);
            Controls.SetChildIndex(btnLED3, 0);
            Controls.SetChildIndex(btnLED4, 0);
            Controls.SetChildIndex(btnReset, 0);
            Controls.SetChildIndex(btnSolve, 0);
            Controls.SetChildIndex(btnStrike, 0);
            Controls.SetChildIndex(btnBack, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLED5;
        private Button btnLED1;
        private Button btnLED2;
        private Button btnLED3;
        private Button btnLED4;
        private System.Windows.Forms.Button btnReset;
    }
}
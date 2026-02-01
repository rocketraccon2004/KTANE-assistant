namespace KTANE_Assistant.Forms
{
	partial class frmAnagrams
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
            label1 = new System.Windows.Forms.Label();
            txtAnagram = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnSolve
            // 
            btnSolve.Click += btnSolve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(12, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 31);
            label1.TabIndex = 82;
            label1.Text = "Anagram:";
            // 
            // txtAnagram
            // 
            txtAnagram.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtAnagram.Location = new System.Drawing.Point(204, 124);
            txtAnagram.Name = "txtAnagram";
            txtAnagram.Size = new System.Drawing.Size(328, 43);
            txtAnagram.TabIndex = 83;
            // 
            // frmAnagrams
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(597, 398);
            Controls.Add(txtAnagram);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Text = "Anagrams";
            Controls.SetChildIndex(btnSolve, 0);
            Controls.SetChildIndex(btnStrike, 0);
            Controls.SetChildIndex(btnBack, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtAnagram, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        public System.Windows.Forms.Button btnSolve;

        #endregion

		private Label label1;
		private TextBox txtAnagram;
	}
}
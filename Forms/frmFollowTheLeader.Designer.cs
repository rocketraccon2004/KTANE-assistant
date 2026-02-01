namespace KTANE_Assistant.Forms
{
	partial class frmFollowTheLeader
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
            txtColors = new TextBox();
            txtNumbers = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblGuide = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(364, 194);
            btnBack.Margin = new Padding(1);
            btnBack.Size = new Size(111, 38);
            // 
            // btnStrike
            // 
            btnStrike.Location = new Point(203, 194);
            btnStrike.Margin = new Padding(1);
            btnStrike.Size = new Size(111, 38);
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(50, 194);
            btnSolve.Margin = new Padding(1);
            btnSolve.Size = new Size(111, 38);
            btnSolve.Click += btnSolve_Click;
            // 
            // txtColors
            // 
            txtColors.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColors.Location = new Point(163, 17);
            txtColors.Margin = new Padding(2);
            txtColors.Multiline = true;
            txtColors.Name = "txtColors";
            txtColors.Size = new Size(278, 77);
            txtColors.TabIndex = 0;
            // 
            // txtNumbers
            // 
            txtNumbers.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumbers.Location = new Point(163, 98);
            txtNumbers.Margin = new Padding(2);
            txtNumbers.Multiline = true;
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(278, 77);
            txtNumbers.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 83;
            label1.Text = "Colors";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 125);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 84;
            label2.Text = "Numbers";
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Location = new Point(501, 49);
            lblGuide.Margin = new Padding(2, 0, 2, 0);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(0, 15);
            lblGuide.TabIndex = 85;
            // 
            // frmFollowTheLeader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 242);
            Controls.Add(lblGuide);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumbers);
            Controls.Add(txtColors);
            Margin = new Padding(2);
            Name = "frmFollowTheLeader";
            Text = "Follow The Leader";
            Load += frmFollowTheLeader_Load;
            Controls.SetChildIndex(btnSolve, 0);
            Controls.SetChildIndex(btnStrike, 0);
            Controls.SetChildIndex(btnBack, 0);
            Controls.SetChildIndex(txtColors, 0);
            Controls.SetChildIndex(txtNumbers, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(lblGuide, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtColors;
		private TextBox txtNumbers;
		private Label label1;
		private Label label2;
		private Label lblGuide;
	}
}
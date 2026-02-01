namespace KTANE_Assistant.Forms
{
	partial class frmBlindAlley
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button8 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333336F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333336F));
            tableLayoutPanel1.Controls.Add(button8, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 1, 2);
            tableLayoutPanel1.Controls.Add(button6, 0, 2);
            tableLayoutPanel1.Controls.Add(button5, 2, 1);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(63, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
            tableLayoutPanel1.Size = new System.Drawing.Size(650, 302);
            tableLayoutPanel1.TabIndex = 82;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(435, 203);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(210, 94);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(219, 203);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(210, 94);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(3, 203);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(210, 94);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(435, 103);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(210, 94);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(219, 103);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(210, 94);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(3, 103);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(210, 94);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(219, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(210, 94);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(3, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(210, 94);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(282, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(210, 67);
            btnBack.TabIndex = 83;
            btnBack.Text = "btnBack";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // frmBlindAlley
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(862, 541);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            Text = "Blind Alley";
            Load += frmBlindAlley_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Button btnBack;
		private TableLayoutPanel tableLayoutPanel1;
		private Button button8;
		private Button button7;
		private Button button6;
		private Button button5;
		private Button button4;
		private Button button3;
		private Button button2;
		private Button button1;
	}
}
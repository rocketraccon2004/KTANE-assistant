namespace KTANE_Assistant.Forms
{
    partial class frmAdjacentLetters
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txt34 = new TextBox();
            txt33 = new TextBox();
            txt31 = new TextBox();
            txt24 = new TextBox();
            txt23 = new TextBox();
            txt21 = new TextBox();
            txt13 = new TextBox();
            txt11 = new TextBox();
            txt14 = new TextBox();
            txt32 = new TextBox();
            txt12 = new TextBox();
            txt22 = new TextBox();
            btnReset = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(335, 253);
            btnBack.Size = new Size(133, 38);
            btnBack.Click += btnBack_Click;
            // 
            // btnStrike
            // 
            btnStrike.Location = new Point(186, 253);
            btnStrike.Size = new Size(137, 38);
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(40, 253);
            btnSolve.Size = new Size(130, 38);
            btnSolve.Click += btnSolve_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(txt34, 3, 2);
            tableLayoutPanel1.Controls.Add(txt33, 2, 2);
            tableLayoutPanel1.Controls.Add(txt31, 0, 2);
            tableLayoutPanel1.Controls.Add(txt24, 3, 1);
            tableLayoutPanel1.Controls.Add(txt23, 2, 1);
            tableLayoutPanel1.Controls.Add(txt21, 0, 1);
            tableLayoutPanel1.Controls.Add(txt13, 2, 0);
            tableLayoutPanel1.Controls.Add(txt11, 0, 0);
            tableLayoutPanel1.Controls.Add(txt14, 3, 0);
            tableLayoutPanel1.Controls.Add(txt32, 1, 2);
            tableLayoutPanel1.Controls.Add(txt12, 1, 1);
            tableLayoutPanel1.Controls.Add(txt22, 1, 0);
            tableLayoutPanel1.Location = new Point(76, 26);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Size = new Size(394, 203);
            tableLayoutPanel1.TabIndex = 79;
            // 
            // txt34
            // 
            txt34.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt34.Location = new Point(296, 136);
            txt34.Margin = new Padding(2);
            txt34.Name = "txt34";
            txt34.Size = new Size(96, 71);
            txt34.TabIndex = 11;
            txt34.TextAlign = HorizontalAlignment.Center;
            // 
            // txt33
            // 
            txt33.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt33.Location = new Point(198, 136);
            txt33.Margin = new Padding(2);
            txt33.Name = "txt33";
            txt33.Size = new Size(94, 71);
            txt33.TabIndex = 10;
            txt33.TextAlign = HorizontalAlignment.Center;
            txt33.TextChanged += TextBox_TextChanged;
            // 
            // txt31
            // 
            txt31.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt31.Location = new Point(2, 136);
            txt31.Margin = new Padding(2);
            txt31.Name = "txt31";
            txt31.Size = new Size(94, 71);
            txt31.TabIndex = 8;
            txt31.TextAlign = HorizontalAlignment.Center;
            txt31.TextChanged += TextBox_TextChanged;
            // 
            // txt24
            // 
            txt24.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt24.Location = new Point(296, 69);
            txt24.Margin = new Padding(2);
            txt24.Name = "txt24";
            txt24.Size = new Size(96, 71);
            txt24.TabIndex = 7;
            txt24.TextAlign = HorizontalAlignment.Center;
            txt24.TextChanged += TextBox_TextChanged;
            // 
            // txt23
            // 
            txt23.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt23.Location = new Point(198, 69);
            txt23.Margin = new Padding(2);
            txt23.Name = "txt23";
            txt23.Size = new Size(94, 71);
            txt23.TabIndex = 6;
            txt23.TextAlign = HorizontalAlignment.Center;
            txt23.TextChanged += TextBox_TextChanged;
            // 
            // txt21
            // 
            txt21.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt21.Location = new Point(2, 69);
            txt21.Margin = new Padding(2);
            txt21.Name = "txt21";
            txt21.Size = new Size(94, 71);
            txt21.TabIndex = 4;
            txt21.TextAlign = HorizontalAlignment.Center;
            txt21.TextChanged += TextBox_TextChanged;
            // 
            // txt13
            // 
            txt13.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt13.Location = new Point(198, 2);
            txt13.Margin = new Padding(2);
            txt13.Name = "txt13";
            txt13.Size = new Size(94, 71);
            txt13.TabIndex = 2;
            txt13.TextAlign = HorizontalAlignment.Center;
            txt13.TextChanged += TextBox_TextChanged;
            // 
            // txt11
            // 
            txt11.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt11.Location = new Point(2, 2);
            txt11.Margin = new Padding(2);
            txt11.Name = "txt11";
            txt11.Size = new Size(94, 71);
            txt11.TabIndex = 0;
            txt11.TextAlign = HorizontalAlignment.Center;
            txt11.TextChanged += TextBox_TextChanged;
            // 
            // txt14
            // 
            txt14.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt14.Location = new Point(296, 2);
            txt14.Margin = new Padding(2);
            txt14.Name = "txt14";
            txt14.Size = new Size(96, 71);
            txt14.TabIndex = 3;
            txt14.TextAlign = HorizontalAlignment.Center;
            txt14.TextChanged += TextBox_TextChanged;
            // 
            // txt32
            // 
            txt32.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt32.Location = new Point(100, 136);
            txt32.Margin = new Padding(2);
            txt32.Name = "txt32";
            txt32.Size = new Size(94, 71);
            txt32.TabIndex = 9;
            txt32.TextAlign = HorizontalAlignment.Center;
            txt32.TextChanged += TextBox_TextChanged;
            // 
            // txt12
            // 
            txt12.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt12.Location = new Point(100, 69);
            txt12.Margin = new Padding(2);
            txt12.Name = "txt12";
            txt12.Size = new Size(94, 71);
            txt12.TabIndex = 1;
            txt12.TextAlign = HorizontalAlignment.Center;
            txt12.TextChanged += TextBox_TextChanged;
            // 
            // txt22
            // 
            txt22.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt22.Location = new Point(100, 2);
            txt22.Margin = new Padding(2);
            txt22.Name = "txt22";
            txt22.Size = new Size(94, 71);
            txt22.TabIndex = 5;
            txt22.TextAlign = HorizontalAlignment.Center;
            txt22.TextChanged += TextBox_TextChanged;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(480, 254);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 38);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmAdjacentLetters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 332);
            Controls.Add(btnReset);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdjacentLetters";
            Text = "Adjacent Letters";
            Load += frmAdjacentLetters_Load;
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            Controls.SetChildIndex(btnReset, 0);
            Controls.SetChildIndex(btnSolve, 0);
            Controls.SetChildIndex(btnStrike, 0);
            Controls.SetChildIndex(btnBack, 0);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button btnStrike;
        public System.Windows.Forms.Button btnSolve;

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt34;
        private System.Windows.Forms.TextBox txt33;
        private System.Windows.Forms.TextBox txt32;
        private System.Windows.Forms.TextBox txt31;
        private System.Windows.Forms.TextBox txt24;
        private System.Windows.Forms.TextBox txt23;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.TextBox txt13;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt14;
        private System.Windows.Forms.Button btnReset;
    }
}
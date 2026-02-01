namespace KTANE_Assistant.Forms
{
    partial class BaseForm
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
            btnBack = new Button();
            btnStrike = new Button();
            btnSolve = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(335, 227);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 64);
            btnBack.TabIndex = 95;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnStrike
            // 
            btnStrike.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStrike.Location = new Point(173, 227);
            btnStrike.Margin = new Padding(2);
            btnStrike.Name = "btnStrike";
            btnStrike.Size = new Size(158, 64);
            btnStrike.TabIndex = 94;
            btnStrike.Text = "Strike";
            btnStrike.UseVisualStyleBackColor = true;
            btnStrike.Click += btnStrike_Click;
            // 
            // btnSolve
            // 
            btnSolve.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolve.Location = new Point(11, 227);
            btnSolve.Margin = new Padding(2);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(158, 64);
            btnSolve.TabIndex = 93;
            btnSolve.Text = "Solve";
            btnSolve.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 301);
            Controls.Add(btnBack);
            Controls.Add(btnStrike);
            Controls.Add(btnSolve);
            Name = "BaseForm";
            FormClosing += BaseForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        public Button btnBack;
        public Button btnStrike;
        public Button btnSolve;
    }
}
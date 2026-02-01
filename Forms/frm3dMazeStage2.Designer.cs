namespace KTANE_Assistant.Forms;
    partial class frm3dMazeStage2
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
        cardinalComboBox = new System.Windows.Forms.ComboBox();
        label2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(244, 146);
        btnBack.Size = new System.Drawing.Size(116, 33);
        // 
        // btnStrike
        // 
        btnStrike.Location = new System.Drawing.Point(136, 146);
        btnStrike.Size = new System.Drawing.Size(104, 33);
        // 
        // btnSolve
        // 
        btnSolve.Location = new System.Drawing.Point(11, 146);
        btnSolve.Size = new System.Drawing.Size(121, 33);
        // 
        // cardinalComboBox
        // 
        cardinalComboBox.FormattingEnabled = true;
        cardinalComboBox.Location = new System.Drawing.Point(113, 74);
        cardinalComboBox.Margin = new System.Windows.Forms.Padding(4);
        cardinalComboBox.Name = "cardinalComboBox";
        cardinalComboBox.Size = new System.Drawing.Size(140, 28);
        cardinalComboBox.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(113, 40);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(140, 20);
        label2.TabIndex = 7;
        label2.Text = "What is the cardinal";
        // 
        // frm3dMazeStage2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(377, 192);
        Controls.Add(cardinalComboBox);
        Controls.Add(label2);
        Text = "KTANE Assistant";
        Controls.SetChildIndex(label2, 0);
        Controls.SetChildIndex(cardinalComboBox, 0);
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.ComboBox cardinalComboBox;
        private System.Windows.Forms.Label label2;
}
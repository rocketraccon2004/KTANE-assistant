namespace KTANE_Assistant.Forms;

    partial class frm3dMaze
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        facingWallCheckBox = new System.Windows.Forms.CheckBox();
        pathTextBox = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        mazeTextBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(350, 341);
        btnBack.Size = new System.Drawing.Size(144, 47);
        // 
        // btnStrike
        // 
        btnStrike.Location = new System.Drawing.Point(198, 341);
        btnStrike.Size = new System.Drawing.Size(148, 47);
        // 
        // btnSolve
        // 
        btnSolve.Location = new System.Drawing.Point(13, 341);
        btnSolve.Size = new System.Drawing.Size(181, 47);
        btnSolve.Click += btnSolve_Click;
        // 
        // facingWallCheckBox
        // 
        facingWallCheckBox.AutoSize = true;
        facingWallCheckBox.Location = new System.Drawing.Point(206, 308);
        facingWallCheckBox.Name = "facingWallCheckBox";
        facingWallCheckBox.Size = new System.Drawing.Size(106, 24);
        facingWallCheckBox.TabIndex = 19;
        facingWallCheckBox.Text = "Facing Wall";
        facingWallCheckBox.UseVisualStyleBackColor = true;
        // 
        // pathTextBox
        // 
        pathTextBox.Location = new System.Drawing.Point(160, 267);
        pathTextBox.Margin = new System.Windows.Forms.Padding(4);
        pathTextBox.Name = "pathTextBox";
        pathTextBox.Size = new System.Drawing.Size(168, 27);
        pathTextBox.TabIndex = 18;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(108, 224);
        label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(360, 20);
        label2.TabIndex = 17;
        label2.Text = "Find a straight path and tell what is there (blanks = ?)";
        // 
        // mazeTextBox
        // 
        mazeTextBox.Location = new System.Drawing.Point(160, 64);
        mazeTextBox.Margin = new System.Windows.Forms.Padding(4);
        mazeTextBox.Name = "mazeTextBox";
        mazeTextBox.Size = new System.Drawing.Size(168, 27);
        mazeTextBox.TabIndex = 16;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(157, 29);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(227, 20);
        label1.TabIndex = 15;
        label1.Text = "What are the letters in the maze?";
        // 
        // frm3dMaze
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(505, 405);
        Controls.Add(facingWallCheckBox);
        Controls.Add(pathTextBox);
        Controls.Add(label2);
        Controls.Add(mazeTextBox);
        Controls.Add(label1);
        Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        Text = "3d Maze";
        Controls.SetChildIndex(label1, 0);
        Controls.SetChildIndex(mazeTextBox, 0);
        Controls.SetChildIndex(label2, 0);
        Controls.SetChildIndex(pathTextBox, 0);
        Controls.SetChildIndex(facingWallCheckBox, 0);
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    public System.Windows.Forms.Button btnSolve;

    #endregion

    private CheckBox facingWallCheckBox;
        private TextBox pathTextBox;
        private Label label2;
        private TextBox mazeTextBox;
        private Label label1;
}
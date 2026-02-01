namespace KTANE_Assistant.Forms;

partial class frmWhosOnFirst
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
        btnSubmit1 = new Button();
        lblPosition = new Label();
        txtWord1 = new TextBox();
        txtWord2 = new TextBox();
        txtSolution = new TextBox();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new Point(213, 427);
        // 
        // btnStrike
        // 
        btnStrike.Location = new Point(41, 427);
        // 
        // btnSolve
        // 
        btnSolve.Location = new Point(275, 126);
        btnSolve.Size = new Size(136, 47);
        btnSolve.Click += btnSolve_Click;
        // 
        // btnSubmit1
        // 
        btnSubmit1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSubmit1.Location = new Point(275, 45);
        btnSubmit1.Margin = new Padding(4, 3, 4, 3);
        btnSubmit1.Name = "btnSubmit1";
        btnSubmit1.Size = new Size(136, 47);
        btnSubmit1.TabIndex = 77;
        btnSubmit1.Text = "Submit";
        btnSubmit1.UseVisualStyleBackColor = true;
        btnSubmit1.Click += btnSubmit1_Click;
        // 
        // lblPosition
        // 
        lblPosition.AutoSize = true;
        lblPosition.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPosition.Location = new Point(24, 201);
        lblPosition.Margin = new Padding(4, 0, 4, 0);
        lblPosition.Name = "lblPosition";
        lblPosition.Size = new Size(0, 20);
        lblPosition.TabIndex = 78;
        // 
        // txtWord1
        // 
        txtWord1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtWord1.Location = new Point(108, 60);
        txtWord1.Margin = new Padding(4, 3, 4, 3);
        txtWord1.Name = "txtWord1";
        txtWord1.Size = new Size(162, 26);
        txtWord1.TabIndex = 80;
        // 
        // txtWord2
        // 
        txtWord2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtWord2.Location = new Point(108, 136);
        txtWord2.Margin = new Padding(4, 3, 4, 3);
        txtWord2.Name = "txtWord2";
        txtWord2.Size = new Size(162, 26);
        txtWord2.TabIndex = 81;
        // 
        // txtSolution
        // 
        txtSolution.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtSolution.Location = new Point(13, 198);
        txtSolution.Margin = new Padding(4, 3, 4, 3);
        txtSolution.Multiline = true;
        txtSolution.Name = "txtSolution";
        txtSolution.ReadOnly = true;
        txtSolution.Size = new Size(403, 224);
        txtSolution.TabIndex = 82;
        // 
        // frmWhosOnFirst
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(428, 502);
        Controls.Add(txtSolution);
        Controls.Add(txtWord2);
        Controls.Add(txtWord1);
        Controls.Add(lblPosition);
        Controls.Add(btnSubmit1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "frmWhosOnFirst";
        Text = "Who's on first";
        Load += frmWhosOnFirst_Load;
        Controls.SetChildIndex(btnSubmit1, 0);
        Controls.SetChildIndex(lblPosition, 0);
        Controls.SetChildIndex(txtWord1, 0);
        Controls.SetChildIndex(txtWord2, 0);
        Controls.SetChildIndex(txtSolution, 0);
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.Button btnSubmit1;
    private Label lblPosition;
    private TextBox txtWord1;
    private TextBox txtWord2;
    private TextBox txtSolution;
}
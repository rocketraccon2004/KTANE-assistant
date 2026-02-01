namespace KTANE_Assistant.Forms;

partial class frmComplicatedWires
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
        cbRedWire = new CheckBox();
        cbBlueWire = new CheckBox();
        cbLED = new CheckBox();
        cbStar = new CheckBox();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new Point(302, 198);
        btnBack.Size = new Size(123, 48);
        // 
        // btnStrike
        // 
        btnStrike.Location = new Point(152, 198);
        btnStrike.Size = new Size(123, 48);
        // 
        // btnSolve
        // 
        btnSolve.Location = new Point(11, 198);
        btnSolve.Size = new Size(123, 48);
        btnSolve.Click += btnSolve_Click;
        // 
        // cbRedWire
        // 
        cbRedWire.AutoSize = true;
        cbRedWire.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbRedWire.Location = new Point(154, 35);
        cbRedWire.Margin = new Padding(2, 2, 2, 2);
        cbRedWire.Name = "cbRedWire";
        cbRedWire.Size = new Size(121, 34);
        cbRedWire.TabIndex = 79;
        cbRedWire.Text = "Red Wire";
        cbRedWire.UseVisualStyleBackColor = true;
        // 
        // cbBlueWire
        // 
        cbBlueWire.AutoSize = true;
        cbBlueWire.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbBlueWire.Location = new Point(154, 73);
        cbBlueWire.Margin = new Padding(2, 2, 2, 2);
        cbBlueWire.Name = "cbBlueWire";
        cbBlueWire.Size = new Size(126, 34);
        cbBlueWire.TabIndex = 80;
        cbBlueWire.Text = "Blue Wire";
        cbBlueWire.UseVisualStyleBackColor = true;
        // 
        // cbLED
        // 
        cbLED.AutoSize = true;
        cbLED.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbLED.Location = new Point(154, 111);
        cbLED.Margin = new Padding(2, 2, 2, 2);
        cbLED.Name = "cbLED";
        cbLED.Size = new Size(103, 34);
        cbLED.TabIndex = 81;
        cbLED.Text = "LED On";
        cbLED.UseVisualStyleBackColor = true;
        // 
        // cbStar
        // 
        cbStar.AutoSize = true;
        cbStar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbStar.Location = new Point(154, 149);
        cbStar.Margin = new Padding(2, 2, 2, 2);
        cbStar.Name = "cbStar";
        cbStar.Size = new Size(147, 34);
        cbStar.TabIndex = 82;
        cbStar.Text = "Star Present";
        cbStar.UseVisualStyleBackColor = true;
        // 
        // frmComplicatedWires
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(463, 268);
        Controls.Add(cbStar);
        Controls.Add(cbLED);
        Controls.Add(cbBlueWire);
        Controls.Add(cbRedWire);
        Margin = new Padding(3, 2, 3, 2);
        Name = "frmComplicatedWires";
        Text = "Complicated Wires";
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        Controls.SetChildIndex(cbRedWire, 0);
        Controls.SetChildIndex(cbBlueWire, 0);
        Controls.SetChildIndex(cbLED, 0);
        Controls.SetChildIndex(cbStar, 0);
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cbRedWire;
    private System.Windows.Forms.CheckBox cbBlueWire;
    private System.Windows.Forms.CheckBox cbLED;
    private System.Windows.Forms.CheckBox cbStar;
}

namespace KTANE_Assistant.Forms;

partial class frmWireSequences
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
        cbWire1Color = new ComboBox();
        cbWire2Color = new ComboBox();
        cbWire3Color = new ComboBox();
        cbWire3End = new ComboBox();
        cbWire1End = new ComboBox();
        cbWire2End = new ComboBox();
        label3 = new Label();
        label4 = new Label();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new Point(373, 246);
        btnBack.Size = new Size(123, 48);
        btnBack.Click += btnBack_Click;
        // 
        // btnStrike
        // 
        btnStrike.Location = new Point(247, 246);
        btnStrike.Size = new Size(123, 48);
        btnStrike.Click += this.btnStrike_Click;
        // 
        // btnSolve
        // 
        btnSolve.Location = new Point(121, 246);
        btnSolve.Size = new Size(123, 48);
        btnSolve.Click += this.btnSolve_Click;
        // 
        // cbWire1Color
        // 
        cbWire1Color.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire1Color.FormattingEnabled = true;
        cbWire1Color.Items.AddRange(new object[] { "", "Red", "Blue", "Black" });
        cbWire1Color.Location = new Point(163, 71);
        cbWire1Color.Name = "cbWire1Color";
        cbWire1Color.Size = new Size(133, 38);
        cbWire1Color.TabIndex = 85;
        // 
        // cbWire2Color
        // 
        cbWire2Color.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire2Color.FormattingEnabled = true;
        cbWire2Color.Items.AddRange(new object[] { "", "Red", "Blue", "Black" });
        cbWire2Color.Location = new Point(163, 131);
        cbWire2Color.Name = "cbWire2Color";
        cbWire2Color.Size = new Size(133, 38);
        cbWire2Color.TabIndex = 86;
        // 
        // cbWire3Color
        // 
        cbWire3Color.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire3Color.FormattingEnabled = true;
        cbWire3Color.Items.AddRange(new object[] { "", "Red", "Blue", "Black" });
        cbWire3Color.Location = new Point(163, 191);
        cbWire3Color.Name = "cbWire3Color";
        cbWire3Color.Size = new Size(133, 38);
        cbWire3Color.TabIndex = 87;
        // 
        // cbWire3End
        // 
        cbWire3End.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire3End.FormattingEnabled = true;
        cbWire3End.Items.AddRange(new object[] { "", "A", "B", "C" });
        cbWire3End.Location = new Point(313, 191);
        cbWire3End.Name = "cbWire3End";
        cbWire3End.Size = new Size(133, 38);
        cbWire3End.TabIndex = 88;
        // 
        // cbWire1End
        // 
        cbWire1End.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire1End.FormattingEnabled = true;
        cbWire1End.Items.AddRange(new object[] { "", "A", "B", "C" });
        cbWire1End.Location = new Point(313, 71);
        cbWire1End.Name = "cbWire1End";
        cbWire1End.Size = new Size(133, 38);
        cbWire1End.TabIndex = 88;
        // 
        // cbWire2End
        // 
        cbWire2End.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire2End.FormattingEnabled = true;
        cbWire2End.Items.AddRange(new object[] { "", "A", "B", "C" });
        cbWire2End.Location = new Point(313, 131);
        cbWire2End.Name = "cbWire2End";
        cbWire2End.Size = new Size(133, 38);
        cbWire2End.TabIndex = 89;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(187, 23);
        label3.Name = "label3";
        label3.Size = new Size(78, 30);
        label3.TabIndex = 91;
        label3.Text = "Color";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(355, 23);
        label4.Name = "label4";
        label4.Size = new Size(49, 30);
        label4.TabIndex = 92;
        label4.Text = "End";
        // 
        // frmWireSequences
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(623, 338);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(cbWire2End);
        Controls.Add(cbWire1End);
        Controls.Add(cbWire3End);
        Controls.Add(cbWire3Color);
        Controls.Add(cbWire2Color);
        Controls.Add(cbWire1Color);
        Name = "frmWireSequences";
        Text = "Wire Sequences";
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        Controls.SetChildIndex(cbWire1Color, 0);
        Controls.SetChildIndex(cbWire2Color, 0);
        Controls.SetChildIndex(cbWire3Color, 0);
        Controls.SetChildIndex(cbWire3End, 0);
        Controls.SetChildIndex(cbWire1End, 0);
        Controls.SetChildIndex(cbWire2End, 0);
        Controls.SetChildIndex(label3, 0);
        Controls.SetChildIndex(label4, 0);
        ResumeLayout(false);
        PerformLayout();

    }
    #endregion
    private ComboBox cbWire1Color;
    private ComboBox cbWire2Color;
    private ComboBox cbWire3Color;
    private ComboBox cbWire3End;
    private ComboBox cbWire1End;
    private ComboBox cbWire2End;
    private Label label3;
    private Label label4;
}
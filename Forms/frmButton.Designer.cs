using System.ComponentModel;

namespace KTANE_Assistant.Forms;

partial class frmButton
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        dropDownColor = new ComboBox();
        dropDownText = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new Point(261, 170);
        btnBack.Size = new Size(123, 48);
        // 
        // btnStrike
        // 
        btnStrike.Location = new Point(135, 170);
        btnStrike.Size = new Size(123, 48);
        // 
        // btnSolve
        // 
        btnSolve.Location = new Point(9, 170);
        btnSolve.Size = new Size(123, 48);
        btnSolve.Click += solve;
        // 
        // dropDownColor
        // 
        dropDownColor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dropDownColor.FormattingEnabled = true;
        dropDownColor.Items.AddRange(new object[] { "Blue", "White", "Yellow", "Red" });
        dropDownColor.Location = new Point(104, 19);
        dropDownColor.Margin = new Padding(2, 3, 2, 3);
        dropDownColor.Name = "dropDownColor";
        dropDownColor.Size = new Size(230, 28);
        dropDownColor.TabIndex = 2;
        // 
        // dropDownText
        // 
        dropDownText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dropDownText.FormattingEnabled = true;
        dropDownText.Items.AddRange(new object[] { "Abort", "Detonate", "Hold", "Press" });
        dropDownText.Location = new Point(104, 91);
        dropDownText.Margin = new Padding(2, 3, 2, 3);
        dropDownText.Name = "dropDownText";
        dropDownText.Size = new Size(230, 28);
        dropDownText.TabIndex = 3;
        // 
        // label1
        // 
        label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(17, 19);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(82, 26);
        label1.TabIndex = 4;
        label1.Text = "Color";
        // 
        // label2
        // 
        label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(17, 93);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(73, 26);
        label2.TabIndex = 5;
        label2.Text = "Label";
        // 
        // frmButton
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(398, 225);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(dropDownText);
        Controls.Add(dropDownColor);
        Margin = new Padding(2, 2, 2, 2);
        Name = "frmButton";
        Text = "Button";
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        Controls.SetChildIndex(dropDownColor, 0);
        Controls.SetChildIndex(dropDownText, 0);
        Controls.SetChildIndex(label1, 0);
        Controls.SetChildIndex(label2, 0);
        ResumeLayout(false);

    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ComboBox dropDownText;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox dropDownColor;

    #endregion
}
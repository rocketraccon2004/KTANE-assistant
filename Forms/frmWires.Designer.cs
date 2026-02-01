using System.ComponentModel;

namespace KTANE_Assistant.Forms;

partial class frmWires
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        comboBox1 = new ComboBox();
        comboBox2 = new ComboBox();
        comboBox3 = new ComboBox();
        comboBox4 = new ComboBox();
        comboBox5 = new ComboBox();
        comboBox6 = new ComboBox();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new Point(291, 294);
        btnBack.Size = new Size(123, 48);
        // 
        // btnStrike
        // 
        btnStrike.Location = new Point(149, 294);
        btnStrike.Size = new Size(123, 48);
        // 
        // btnSolve
        // 
        btnSolve.Location = new Point(11, 294);
        btnSolve.Size = new Size(123, 48);
        btnSolve.Click += btnSolve_Click;
        // 
        // label1
        // 
        label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(34, 46);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(87, 22);
        label1.TabIndex = 1;
        label1.Text = "Wire 1:";
        // 
        // label2
        // 
        label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(34, 88);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(87, 22);
        label2.TabIndex = 2;
        label2.Text = "Wire 2:";
        // 
        // label3
        // 
        label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(34, 119);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(87, 22);
        label3.TabIndex = 3;
        label3.Text = "Wire 3:";
        // 
        // label4
        // 
        label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(34, 156);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(87, 22);
        label4.TabIndex = 4;
        label4.Text = "Wire 4:";
        // 
        // label5
        // 
        label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(34, 192);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(87, 22);
        label5.TabIndex = 5;
        label5.Text = "Wire 5:";
        // 
        // label6
        // 
        label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(34, 229);
        label6.Margin = new Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Size = new Size(87, 22);
        label6.TabIndex = 6;
        label6.Text = "Wire 6:";
        // 
        // comboBox1
        // 
        comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "", "Black", "Blue", "Red", "White", "Yellow" });
        comboBox1.Location = new Point(112, 44);
        comboBox1.Margin = new Padding(2, 3, 2, 3);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(146, 28);
        comboBox1.TabIndex = 7;
        // 
        // comboBox2
        // 
        comboBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox2.FormattingEnabled = true;
        comboBox2.Items.AddRange(new object[] { "", "Black", "Blue", "Red", "White", "Yellow" });
        comboBox2.Location = new Point(112, 80);
        comboBox2.Margin = new Padding(2, 3, 2, 3);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(146, 28);
        comboBox2.TabIndex = 8;
        // 
        // comboBox3
        // 
        comboBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox3.FormattingEnabled = true;
        comboBox3.Items.AddRange(new object[] { "", "Black", "Blue", "Red", "White", "Yellow" });
        comboBox3.Location = new Point(112, 116);
        comboBox3.Margin = new Padding(2, 3, 2, 3);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new Size(146, 28);
        comboBox3.TabIndex = 9;
        // 
        // comboBox4
        // 
        comboBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox4.FormattingEnabled = true;
        comboBox4.Items.AddRange(new object[] { "", "Black", "Blue", "Red", "White", "Yellow" });
        comboBox4.Location = new Point(112, 153);
        comboBox4.Margin = new Padding(2, 3, 2, 3);
        comboBox4.Name = "comboBox4";
        comboBox4.Size = new Size(146, 28);
        comboBox4.TabIndex = 10;
        // 
        // comboBox5
        // 
        comboBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox5.FormattingEnabled = true;
        comboBox5.Items.AddRange(new object[] { "", "Black", "Blue", "Red", "White", "Yellow" });
        comboBox5.Location = new Point(112, 189);
        comboBox5.Margin = new Padding(2, 3, 2, 3);
        comboBox5.Name = "comboBox5";
        comboBox5.Size = new Size(146, 28);
        comboBox5.TabIndex = 11;
        // 
        // comboBox6
        // 
        comboBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox6.FormattingEnabled = true;
        comboBox6.Items.AddRange(new object[] { "", "Black", "Blue", "Red", "White", "Yellow" });
        comboBox6.Location = new Point(112, 226);
        comboBox6.Margin = new Padding(2, 3, 2, 3);
        comboBox6.Name = "comboBox6";
        comboBox6.Size = new Size(146, 28);
        comboBox6.TabIndex = 12;
        // 
        // frmWires
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(436, 357);
        Controls.Add(comboBox6);
        Controls.Add(comboBox5);
        Controls.Add(comboBox4);
        Controls.Add(comboBox3);
        Controls.Add(comboBox2);
        Controls.Add(comboBox1);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Margin = new Padding(2, 3, 2, 3);
        Name = "frmWires";
        Text = "Wires";
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        Controls.SetChildIndex(label1, 0);
        Controls.SetChildIndex(label2, 0);
        Controls.SetChildIndex(label3, 0);
        Controls.SetChildIndex(label4, 0);
        Controls.SetChildIndex(label5, 0);
        Controls.SetChildIndex(label6, 0);
        Controls.SetChildIndex(comboBox1, 0);
        Controls.SetChildIndex(comboBox2, 0);
        Controls.SetChildIndex(comboBox3, 0);
        Controls.SetChildIndex(comboBox4, 0);
        Controls.SetChildIndex(comboBox5, 0);
        Controls.SetChildIndex(comboBox6, 0);
        ResumeLayout(false);

    }

    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.ComboBox comboBox3;
    private System.Windows.Forms.ComboBox comboBox4;
    private System.Windows.Forms.ComboBox comboBox5;
    private System.Windows.Forms.ComboBox comboBox6;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}
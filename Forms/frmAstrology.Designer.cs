using System.ComponentModel;

namespace KTANE_Assistant.Forms;

partial class frmAstrology
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
        btnZodiac = new System.Windows.Forms.Button();
        btnBody = new System.Windows.Forms.Button();
        btnElement = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(451, 303);
        // 
        // btnStrike
        // 
        btnStrike.Location = new System.Drawing.Point(260, 303);
        // 
        // btnSolve
        // 
        btnSolve.Location = new System.Drawing.Point(69, 303);
        btnSolve.Click += btnSolve_Click;
        // 
        // btnZodiac
        // 
        btnZodiac.BackColor = System.Drawing.SystemColors.Window;
        btnZodiac.Location = new System.Drawing.Point(447, 35);
        btnZodiac.Name = "btnZodiac";
        btnZodiac.Size = new System.Drawing.Size(185, 138);
        btnZodiac.TabIndex = 82;
        btnZodiac.UseVisualStyleBackColor = false;
        btnZodiac.Click += btnZodiac_Click;
        // 
        // btnBody
        // 
        btnBody.BackColor = System.Drawing.SystemColors.Window;
        btnBody.Location = new System.Drawing.Point(256, 35);
        btnBody.Name = "btnBody";
        btnBody.Size = new System.Drawing.Size(185, 138);
        btnBody.TabIndex = 83;
        btnBody.UseVisualStyleBackColor = false;
        btnBody.Click += btnBody_Click;
        // 
        // btnElement
        // 
        btnElement.BackColor = System.Drawing.SystemColors.Window;
        btnElement.Location = new System.Drawing.Point(65, 35);
        btnElement.Name = "btnElement";
        btnElement.Size = new System.Drawing.Size(185, 138);
        btnElement.TabIndex = 84;
        btnElement.UseVisualStyleBackColor = false;
        btnElement.Click += btnElement_Click;
        // 
        // frmAstrology
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(759, 465);
        Controls.Add(btnElement);
        Controls.Add(btnBody);
        Controls.Add(btnZodiac);
        Text = "Astrology";
        Load += onLoad;
        Controls.SetChildIndex(btnZodiac, 0);
        Controls.SetChildIndex(btnBody, 0);
        Controls.SetChildIndex(btnElement, 0);
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnZodiac;
    private System.Windows.Forms.Button btnBody;
    private System.Windows.Forms.Button btnElement;

    #endregion
}
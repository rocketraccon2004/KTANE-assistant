using System.ComponentModel;

namespace KTANE_Assistant.Forms;

partial class frmAdventureGame
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
        ddMonster = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        txtSTR = new System.Windows.Forms.TextBox();
        txtPressure = new System.Windows.Forms.TextBox();
        txtGravity = new System.Windows.Forms.TextBox();
        txtTemperature = new System.Windows.Forms.TextBox();
        txtHeight = new System.Windows.Forms.TextBox();
        txtINT = new System.Windows.Forms.TextBox();
        txtDEX = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        cbBroadsword = new System.Windows.Forms.CheckBox();
        cbGrimoire = new System.Windows.Forms.CheckBox();
        cbMagicOrb = new System.Windows.Forms.CheckBox();
        cbLongbow = new System.Windows.Forms.CheckBox();
        cbNastyKnife = new System.Windows.Forms.CheckBox();
        cbCaber = new System.Windows.Forms.CheckBox();
        cbCrystalBall = new System.Windows.Forms.CheckBox();
        cbTrophy = new System.Windows.Forms.CheckBox();
        cbTicket = new System.Windows.Forms.CheckBox();
        cbSymbol = new System.Windows.Forms.CheckBox();
        cbSunstone = new System.Windows.Forms.CheckBox();
        cbStepladder = new System.Windows.Forms.CheckBox();
        cbSmallDog = new System.Windows.Forms.CheckBox();
        cbMoonstone = new System.Windows.Forms.CheckBox();
        cbLamp = new System.Windows.Forms.CheckBox();
        cbHardDrive = new System.Windows.Forms.CheckBox();
        cbFeather = new System.Windows.Forms.CheckBox();
        cbBattery = new System.Windows.Forms.CheckBox();
        cbBalloon = new System.Windows.Forms.CheckBox();
        cbBellows = new System.Windows.Forms.CheckBox();
        txtHeightInches = new System.Windows.Forms.TextBox();
        label11 = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        btnReset = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(681, 425);
        btnBack.Size = new System.Drawing.Size(157, 63);
        // 
        // btnStrike
        // 
        btnStrike.Location = new System.Drawing.Point(496, 425);
        btnStrike.Size = new System.Drawing.Size(167, 63);
        // 
        // btnSolve
        // 
        btnSolve.Location = new System.Drawing.Point(322, 425);
        btnSolve.Size = new System.Drawing.Size(148, 63);
        btnSolve.Click += btnSolve_Click;
        // 
        // ddMonster
        // 
        ddMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        ddMonster.FormattingEnabled = true;
        ddMonster.Items.AddRange(new object[] { "Demon", "Dragon", "Eagle", "Goblin", "Golem", "Troll", "Lizard", "Wizard" });
        ddMonster.Location = new System.Drawing.Point(242, 35);
        ddMonster.Margin = new System.Windows.Forms.Padding(2);
        ddMonster.Name = "ddMonster";
        ddMonster.Size = new System.Drawing.Size(136, 39);
        ddMonster.TabIndex = 82;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(124, 37);
        label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(120, 31);
        label1.TabIndex = 83;
        label1.Text = "Monster:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(167, 88);
        label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(77, 31);
        label2.TabIndex = 84;
        label2.Text = "STR:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(165, 125);
        label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(78, 31);
        label3.TabIndex = 85;
        label3.Text = "DEX:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(175, 163);
        label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(67, 31);
        label4.TabIndex = 86;
        label4.Text = "INT:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(124, 201);
        label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(126, 31);
        label5.TabIndex = 87;
        label5.Text = "HEIGHT:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(31, 238);
        label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(228, 31);
        label6.TabIndex = 88;
        label6.Text = "TEMPERATURE:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(107, 275);
        label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(142, 31);
        label7.TabIndex = 89;
        label7.Text = "GRAVITY:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(83, 313);
        label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(172, 31);
        label8.TabIndex = 90;
        label8.Text = "PRESSURE:";
        // 
        // txtSTR
        // 
        txtSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtSTR.Location = new System.Drawing.Point(242, 85);
        txtSTR.Margin = new System.Windows.Forms.Padding(2);
        txtSTR.Name = "txtSTR";
        txtSTR.Size = new System.Drawing.Size(99, 38);
        txtSTR.TabIndex = 91;
        // 
        // txtPressure
        // 
        txtPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtPressure.Location = new System.Drawing.Point(242, 311);
        txtPressure.Margin = new System.Windows.Forms.Padding(2);
        txtPressure.Name = "txtPressure";
        txtPressure.Size = new System.Drawing.Size(99, 38);
        txtPressure.TabIndex = 98;
        // 
        // txtGravity
        // 
        txtGravity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtGravity.Location = new System.Drawing.Point(242, 273);
        txtGravity.Margin = new System.Windows.Forms.Padding(2);
        txtGravity.Name = "txtGravity";
        txtGravity.Size = new System.Drawing.Size(99, 38);
        txtGravity.TabIndex = 97;
        // 
        // txtTemperature
        // 
        txtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTemperature.Location = new System.Drawing.Point(242, 235);
        txtTemperature.Margin = new System.Windows.Forms.Padding(2);
        txtTemperature.Name = "txtTemperature";
        txtTemperature.Size = new System.Drawing.Size(99, 38);
        txtTemperature.TabIndex = 96;
        // 
        // txtHeight
        // 
        txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtHeight.Location = new System.Drawing.Point(242, 199);
        txtHeight.Margin = new System.Windows.Forms.Padding(2);
        txtHeight.Name = "txtHeight";
        txtHeight.Size = new System.Drawing.Size(36, 38);
        txtHeight.TabIndex = 94;
        // 
        // txtINT
        // 
        txtINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtINT.Location = new System.Drawing.Point(242, 161);
        txtINT.Margin = new System.Windows.Forms.Padding(2);
        txtINT.Name = "txtINT";
        txtINT.Size = new System.Drawing.Size(99, 38);
        txtINT.TabIndex = 93;
        // 
        // txtDEX
        // 
        txtDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtDEX.Location = new System.Drawing.Point(242, 123);
        txtDEX.Margin = new System.Windows.Forms.Padding(2);
        txtDEX.Name = "txtDEX";
        txtDEX.Size = new System.Drawing.Size(99, 38);
        txtDEX.TabIndex = 92;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(512, 41);
        label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(128, 31);
        label9.TabIndex = 98;
        label9.Text = "Weapons";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.Location = new System.Drawing.Point(796, 41);
        label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(81, 31);
        label10.TabIndex = 99;
        label10.Text = "Items";
        // 
        // cbBroadsword
        // 
        cbBroadsword.AutoSize = true;
        cbBroadsword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbBroadsword.Location = new System.Drawing.Point(517, 85);
        cbBroadsword.Margin = new System.Windows.Forms.Padding(2);
        cbBroadsword.Name = "cbBroadsword";
        cbBroadsword.Size = new System.Drawing.Size(181, 35);
        cbBroadsword.TabIndex = 100;
        cbBroadsword.Text = "Broadsword";
        cbBroadsword.UseVisualStyleBackColor = true;
        // 
        // cbGrimoire
        // 
        cbGrimoire.AutoSize = true;
        cbGrimoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbGrimoire.Location = new System.Drawing.Point(517, 262);
        cbGrimoire.Margin = new System.Windows.Forms.Padding(2);
        cbGrimoire.Name = "cbGrimoire";
        cbGrimoire.Size = new System.Drawing.Size(139, 35);
        cbGrimoire.TabIndex = 101;
        cbGrimoire.Text = "Grimoire";
        cbGrimoire.UseVisualStyleBackColor = true;
        // 
        // cbMagicOrb
        // 
        cbMagicOrb.AutoSize = true;
        cbMagicOrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbMagicOrb.Location = new System.Drawing.Point(517, 227);
        cbMagicOrb.Margin = new System.Windows.Forms.Padding(2);
        cbMagicOrb.Name = "cbMagicOrb";
        cbMagicOrb.Size = new System.Drawing.Size(160, 35);
        cbMagicOrb.TabIndex = 102;
        cbMagicOrb.Text = "Magic Orb";
        cbMagicOrb.UseVisualStyleBackColor = true;
        // 
        // cbLongbow
        // 
        cbLongbow.AutoSize = true;
        cbLongbow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbLongbow.Location = new System.Drawing.Point(517, 191);
        cbLongbow.Margin = new System.Windows.Forms.Padding(2);
        cbLongbow.Name = "cbLongbow";
        cbLongbow.Size = new System.Drawing.Size(146, 35);
        cbLongbow.TabIndex = 103;
        cbLongbow.Text = "Longbow";
        cbLongbow.UseVisualStyleBackColor = true;
        // 
        // cbNastyKnife
        // 
        cbNastyKnife.AutoSize = true;
        cbNastyKnife.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbNastyKnife.Location = new System.Drawing.Point(517, 156);
        cbNastyKnife.Margin = new System.Windows.Forms.Padding(2);
        cbNastyKnife.Name = "cbNastyKnife";
        cbNastyKnife.Size = new System.Drawing.Size(176, 35);
        cbNastyKnife.TabIndex = 104;
        cbNastyKnife.Text = "Nasty Knife";
        cbNastyKnife.UseVisualStyleBackColor = true;
        // 
        // cbCaber
        // 
        cbCaber.AutoSize = true;
        cbCaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbCaber.Location = new System.Drawing.Point(517, 121);
        cbCaber.Margin = new System.Windows.Forms.Padding(2);
        cbCaber.Name = "cbCaber";
        cbCaber.Size = new System.Drawing.Size(110, 35);
        cbCaber.TabIndex = 105;
        cbCaber.Text = "Caber";
        cbCaber.UseVisualStyleBackColor = true;
        // 
        // cbCrystalBall
        // 
        cbCrystalBall.AutoSize = true;
        cbCrystalBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbCrystalBall.Location = new System.Drawing.Point(748, 191);
        cbCrystalBall.Margin = new System.Windows.Forms.Padding(2);
        cbCrystalBall.Name = "cbCrystalBall";
        cbCrystalBall.Size = new System.Drawing.Size(174, 35);
        cbCrystalBall.TabIndex = 106;
        cbCrystalBall.Text = "Crystal Ball";
        cbCrystalBall.UseVisualStyleBackColor = true;
        // 
        // cbTrophy
        // 
        cbTrophy.AutoSize = true;
        cbTrophy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbTrophy.Location = new System.Drawing.Point(918, 291);
        cbTrophy.Margin = new System.Windows.Forms.Padding(2);
        cbTrophy.Name = "cbTrophy";
        cbTrophy.Size = new System.Drawing.Size(121, 35);
        cbTrophy.TabIndex = 107;
        cbTrophy.Text = "Trophy";
        cbTrophy.UseVisualStyleBackColor = true;
        // 
        // cbTicket
        // 
        cbTicket.AutoSize = true;
        cbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbTicket.Location = new System.Drawing.Point(918, 256);
        cbTicket.Margin = new System.Windows.Forms.Padding(2);
        cbTicket.Name = "cbTicket";
        cbTicket.Size = new System.Drawing.Size(110, 35);
        cbTicket.TabIndex = 108;
        cbTicket.Text = "Ticket";
        cbTicket.UseVisualStyleBackColor = true;
        // 
        // cbSymbol
        // 
        cbSymbol.AutoSize = true;
        cbSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbSymbol.Location = new System.Drawing.Point(918, 226);
        cbSymbol.Margin = new System.Windows.Forms.Padding(2);
        cbSymbol.Name = "cbSymbol";
        cbSymbol.Size = new System.Drawing.Size(126, 35);
        cbSymbol.TabIndex = 109;
        cbSymbol.Text = "Symbol";
        cbSymbol.UseVisualStyleBackColor = true;
        // 
        // cbSunstone
        // 
        cbSunstone.AutoSize = true;
        cbSunstone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbSunstone.Location = new System.Drawing.Point(918, 191);
        cbSunstone.Margin = new System.Windows.Forms.Padding(2);
        cbSunstone.Name = "cbSunstone";
        cbSunstone.Size = new System.Drawing.Size(151, 35);
        cbSunstone.TabIndex = 110;
        cbSunstone.Text = "Sunstone";
        cbSunstone.UseVisualStyleBackColor = true;
        // 
        // cbStepladder
        // 
        cbStepladder.AutoSize = true;
        cbStepladder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbStepladder.Location = new System.Drawing.Point(918, 155);
        cbStepladder.Margin = new System.Windows.Forms.Padding(2);
        cbStepladder.Name = "cbStepladder";
        cbStepladder.Size = new System.Drawing.Size(167, 35);
        cbStepladder.TabIndex = 111;
        cbStepladder.Text = "Stepladder";
        cbStepladder.UseVisualStyleBackColor = true;
        // 
        // cbSmallDog
        // 
        cbSmallDog.AutoSize = true;
        cbSmallDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbSmallDog.Location = new System.Drawing.Point(918, 121);
        cbSmallDog.Margin = new System.Windows.Forms.Padding(2);
        cbSmallDog.Name = "cbSmallDog";
        cbSmallDog.Size = new System.Drawing.Size(160, 35);
        cbSmallDog.TabIndex = 112;
        cbSmallDog.Text = "Small Dog";
        cbSmallDog.UseVisualStyleBackColor = true;
        // 
        // cbMoonstone
        // 
        cbMoonstone.AutoSize = true;
        cbMoonstone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbMoonstone.Location = new System.Drawing.Point(918, 88);
        cbMoonstone.Margin = new System.Windows.Forms.Padding(2);
        cbMoonstone.Name = "cbMoonstone";
        cbMoonstone.Size = new System.Drawing.Size(170, 35);
        cbMoonstone.TabIndex = 113;
        cbMoonstone.Text = "Moonstone";
        cbMoonstone.UseVisualStyleBackColor = true;
        // 
        // cbLamp
        // 
        cbLamp.AutoSize = true;
        cbLamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbLamp.Location = new System.Drawing.Point(749, 296);
        cbLamp.Margin = new System.Windows.Forms.Padding(2);
        cbLamp.Name = "cbLamp";
        cbLamp.Size = new System.Drawing.Size(103, 35);
        cbLamp.TabIndex = 115;
        cbLamp.Text = "Lamp";
        cbLamp.UseVisualStyleBackColor = true;
        // 
        // cbHardDrive
        // 
        cbHardDrive.AutoSize = true;
        cbHardDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbHardDrive.Location = new System.Drawing.Point(748, 261);
        cbHardDrive.Margin = new System.Windows.Forms.Padding(2);
        cbHardDrive.Name = "cbHardDrive";
        cbHardDrive.Size = new System.Drawing.Size(166, 35);
        cbHardDrive.TabIndex = 116;
        cbHardDrive.Text = "Hard Drive";
        cbHardDrive.UseVisualStyleBackColor = true;
        // 
        // cbFeather
        // 
        cbFeather.AutoSize = true;
        cbFeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbFeather.Location = new System.Drawing.Point(748, 226);
        cbFeather.Margin = new System.Windows.Forms.Padding(2);
        cbFeather.Name = "cbFeather";
        cbFeather.Size = new System.Drawing.Size(130, 35);
        cbFeather.TabIndex = 117;
        cbFeather.Text = "Feather";
        cbFeather.UseVisualStyleBackColor = true;
        // 
        // cbBattery
        // 
        cbBattery.AutoSize = true;
        cbBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbBattery.Location = new System.Drawing.Point(748, 120);
        cbBattery.Margin = new System.Windows.Forms.Padding(2);
        cbBattery.Name = "cbBattery";
        cbBattery.Size = new System.Drawing.Size(123, 35);
        cbBattery.TabIndex = 118;
        cbBattery.Text = "Battery";
        cbBattery.UseVisualStyleBackColor = true;
        // 
        // cbBalloon
        // 
        cbBalloon.AutoSize = true;
        cbBalloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbBalloon.Location = new System.Drawing.Point(748, 85);
        cbBalloon.Margin = new System.Windows.Forms.Padding(2);
        cbBalloon.Name = "cbBalloon";
        cbBalloon.Size = new System.Drawing.Size(126, 35);
        cbBalloon.TabIndex = 120;
        cbBalloon.Text = "Balloon";
        cbBalloon.UseVisualStyleBackColor = true;
        // 
        // cbBellows
        // 
        cbBellows.AutoSize = true;
        cbBellows.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbBellows.Location = new System.Drawing.Point(748, 155);
        cbBellows.Margin = new System.Windows.Forms.Padding(2);
        cbBellows.Name = "cbBellows";
        cbBellows.Size = new System.Drawing.Size(130, 35);
        cbBellows.TabIndex = 121;
        cbBellows.Text = "Bellows";
        cbBellows.UseVisualStyleBackColor = true;
        // 
        // txtHeightInches
        // 
        txtHeightInches.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtHeightInches.Location = new System.Drawing.Point(306, 199);
        txtHeightInches.Margin = new System.Windows.Forms.Padding(2);
        txtHeightInches.Name = "txtHeightInches";
        txtHeightInches.Size = new System.Drawing.Size(36, 38);
        txtHeightInches.TabIndex = 95;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.Location = new System.Drawing.Point(344, 199);
        label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(24, 31);
        label11.TabIndex = 123;
        label11.Text = "\"";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(281, 199);
        label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(19, 31);
        label12.TabIndex = 124;
        label12.Text = "\'";
        // 
        // btnReset
        // 
        btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnReset.Location = new System.Drawing.Point(145, 425);
        btnReset.Margin = new System.Windows.Forms.Padding(2);
        btnReset.Name = "btnReset";
        btnReset.Size = new System.Drawing.Size(153, 63);
        btnReset.TabIndex = 125;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // frmAdventureGame
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(1091, 529);
        Controls.Add(btnReset);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(txtHeightInches);
        Controls.Add(cbBellows);
        Controls.Add(cbBalloon);
        Controls.Add(cbBattery);
        Controls.Add(cbFeather);
        Controls.Add(cbHardDrive);
        Controls.Add(cbLamp);
        Controls.Add(cbMoonstone);
        Controls.Add(cbSmallDog);
        Controls.Add(cbStepladder);
        Controls.Add(cbSunstone);
        Controls.Add(cbSymbol);
        Controls.Add(cbTicket);
        Controls.Add(cbTrophy);
        Controls.Add(cbCrystalBall);
        Controls.Add(cbCaber);
        Controls.Add(cbNastyKnife);
        Controls.Add(cbLongbow);
        Controls.Add(cbMagicOrb);
        Controls.Add(cbGrimoire);
        Controls.Add(cbBroadsword);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(txtDEX);
        Controls.Add(txtINT);
        Controls.Add(txtHeight);
        Controls.Add(txtTemperature);
        Controls.Add(txtGravity);
        Controls.Add(txtPressure);
        Controls.Add(txtSTR);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(ddMonster);
        Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        Text = "Adventure Game";
        Load += frmAdventureGame_Load;
        Controls.SetChildIndex(btnSolve, 0);
        Controls.SetChildIndex(btnStrike, 0);
        Controls.SetChildIndex(btnBack, 0);
        Controls.SetChildIndex(ddMonster, 0);
        Controls.SetChildIndex(label1, 0);
        Controls.SetChildIndex(label2, 0);
        Controls.SetChildIndex(label3, 0);
        Controls.SetChildIndex(label4, 0);
        Controls.SetChildIndex(label5, 0);
        Controls.SetChildIndex(label6, 0);
        Controls.SetChildIndex(label7, 0);
        Controls.SetChildIndex(label8, 0);
        Controls.SetChildIndex(txtSTR, 0);
        Controls.SetChildIndex(txtPressure, 0);
        Controls.SetChildIndex(txtGravity, 0);
        Controls.SetChildIndex(txtTemperature, 0);
        Controls.SetChildIndex(txtHeight, 0);
        Controls.SetChildIndex(txtINT, 0);
        Controls.SetChildIndex(txtDEX, 0);
        Controls.SetChildIndex(label9, 0);
        Controls.SetChildIndex(label10, 0);
        Controls.SetChildIndex(cbBroadsword, 0);
        Controls.SetChildIndex(cbGrimoire, 0);
        Controls.SetChildIndex(cbMagicOrb, 0);
        Controls.SetChildIndex(cbLongbow, 0);
        Controls.SetChildIndex(cbNastyKnife, 0);
        Controls.SetChildIndex(cbCaber, 0);
        Controls.SetChildIndex(cbCrystalBall, 0);
        Controls.SetChildIndex(cbTrophy, 0);
        Controls.SetChildIndex(cbTicket, 0);
        Controls.SetChildIndex(cbSymbol, 0);
        Controls.SetChildIndex(cbSunstone, 0);
        Controls.SetChildIndex(cbStepladder, 0);
        Controls.SetChildIndex(cbSmallDog, 0);
        Controls.SetChildIndex(cbMoonstone, 0);
        Controls.SetChildIndex(cbLamp, 0);
        Controls.SetChildIndex(cbHardDrive, 0);
        Controls.SetChildIndex(cbFeather, 0);
        Controls.SetChildIndex(cbBattery, 0);
        Controls.SetChildIndex(cbBalloon, 0);
        Controls.SetChildIndex(cbBellows, 0);
        Controls.SetChildIndex(txtHeightInches, 0);
        Controls.SetChildIndex(label11, 0);
        Controls.SetChildIndex(label12, 0);
        Controls.SetChildIndex(btnReset, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    public System.Windows.Forms.Button btnSolve;

    #endregion

    private ComboBox ddMonster;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private TextBox txtSTR;
    private TextBox txtPressure;
    private TextBox txtGravity;
    private TextBox txtTemperature;
    private TextBox txtHeight;
    private TextBox txtINT;
    private TextBox txtDEX;
    private Label label9;
    private Label label10;
    private CheckBox cbBroadsword;
    private CheckBox cbGrimoire;
    private CheckBox cbMagicOrb;
    private CheckBox cbLongbow;
    private CheckBox cbNastyKnife;
    private CheckBox cbCaber;
    private CheckBox cbCrystalBall;
    private CheckBox cbTrophy;
    private CheckBox cbTicket;
    private CheckBox cbSymbol;
    private CheckBox cbSunstone;
    private CheckBox cbStepladder;
    private CheckBox cbSmallDog;
    private CheckBox cbMoonstone;
    private CheckBox cbLamp;
    private CheckBox cbHardDrive;
    private CheckBox cbFeather;
    private CheckBox cbBattery;
    private CheckBox cbBalloon;
    private CheckBox cbBellows;
	private TextBox txtHeightInches;
	private Label label11;
	private Label label12;
	private Button btnReset;
}
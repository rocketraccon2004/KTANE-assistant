using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmWires : BaseForm
{
    private string[] wires;

    public frmWires(bool showButtons) : base(showButtons)
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        wires = 
        [
            comboBox1.Text,
            comboBox2.Text,
            comboBox3.Text,
            comboBox4.Text,
            comboBox5.Text,
            comboBox6.Text
        ];

        var module = new Wires(wires);
        module.Solve();
    }
}
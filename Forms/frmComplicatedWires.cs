using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmComplicatedWires : BaseForm
{
    private ComplicatedWires module;

    public frmComplicatedWires(bool showButtons) : base(showButtons)
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        module = new ComplicatedWires(cbRedWire.Checked, cbBlueWire.Checked, cbLED.Checked, cbStar.Checked);
        module.Solve();
    }
}
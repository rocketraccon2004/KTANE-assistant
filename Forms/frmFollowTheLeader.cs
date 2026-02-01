using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmFollowTheLeader : BaseForm
{
    public frmFollowTheLeader(bool showButtons) : base(showButtons)
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        var module = new followTheLeader(txtColors.Text, txtNumbers.Text);
        module.Solve();
    }

    private void frmFollowTheLeader_Load(object sender, EventArgs e)
    {
        lblGuide.Text = @"red - r
blue - b
black - blk
white - w
green - g
yellow - y";
    }
}
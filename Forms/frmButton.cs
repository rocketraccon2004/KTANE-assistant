using Button = KTANE_Assistant.Modules.Button;

namespace KTANE_Assistant.Forms;

public partial class frmButton : BaseForm
{
    public Button button;

    public frmButton(bool showButtons) : base(showButtons)
    {
        InitializeComponent();
    }

    private void solve(object sender, EventArgs e)
    {
        button = new Button(dropDownColor.Text, dropDownText.Text);
        button.Solve();
    }
}
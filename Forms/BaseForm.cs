namespace KTANE_Assistant.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm(bool showButtons)
        {
            InitializeComponent();
            if (!showButtons)
            {
                btnBack.Visible = false;
                btnSolve.Visible = false;
                btnStrike.Visible = false;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
        }

        public void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Visible)
            {
                Assistant.Instance.formClosed(e);
            }
        }

        public void btnStrike_Click(object sender, EventArgs e)
        {
            Assistant.Instance.strikeButtonClicked(ModifierKeys.HasFlag(Keys.Shift));
        }

        public void btnBack_Click(object sender, EventArgs e)
        {
            Assistant.Instance.backButtonClicked();
        }
    }
}

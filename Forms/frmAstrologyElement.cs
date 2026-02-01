namespace KTANE_Assistant.Forms;

public partial class frmAstrologyElement : BaseForm
{
    frmAstrology Form;

    public frmAstrologyElement(bool showButtons) : base(showButtons)
    {
        InitializeComponent();
    }

    public void selectElement(frmAstrology Form)
    {
        this.Form = Form;
        Program.switchForm(this);
    }

    private void select(object sender, EventArgs e)
    {
        string Element = ((Button)sender).Name.Replace("btn", string.Empty);
        Form.module.element = Element;
        Form.setElement(Element);
        Program.switchForm(Form);
    }
}
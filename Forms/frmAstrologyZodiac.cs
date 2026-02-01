namespace KTANE_Assistant.Forms;

public partial class frmAstrologyZodiac : BaseForm
{
    frmAstrology Form;

    public frmAstrologyZodiac(bool showButtons) : base(showButtons)
    {
        InitializeComponent();
    }

    public void selectZodiac(frmAstrology Form)
    {
        this.Form = Form;
        Program.switchForm(this);
    }

    private void select(object sender, EventArgs e)
    {
        string zodiac = ((Button)sender).Name.Replace("btn", string.Empty);
        Form.module.zodiac = zodiac;
        Form.setZodiac(zodiac);
        Program.switchForm(Form);
    }
}
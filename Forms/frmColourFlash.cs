using KTANE_Assistant.Modules;

namespace KTANE_Assistant.Forms;

public partial class frmColorFlash : BaseForm
{
    private List<string> colours = new();
    private ColorFlash module;

    private List<string> possibleWords =
    [
        "Red",
        "Yellow",
        "Green",
        "Blue",
        "Magenta",
        "White"
    ];

    private List<string> words = new();

    public frmColorFlash(bool showButtons) : base(showButtons)
    {
        InitializeComponent();
    }

    private void frmColorFlash_Load(object sender, EventArgs e)
    {
        foreach (var s in possibleWords)
        {
            cbWord1.Items.Add(s);
            cbWord2.Items.Add(s);
            cbWord3.Items.Add(s);
            cbWord4.Items.Add(s);
            cbWord5.Items.Add(s);
            cbWord6.Items.Add(s);
            cbWord7.Items.Add(s);
            cbWord8.Items.Add(s);
            cbColor1.Items.Add(s);
            cbColor2.Items.Add(s);
            cbColor3.Items.Add(s);
            cbColor4.Items.Add(s);
            cbColor5.Items.Add(s);
            cbColor6.Items.Add(s);
            cbColor7.Items.Add(s);
            cbColor8.Items.Add(s);
        }
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        words.Add(cbWord1.Text);
        words.Add(cbWord2.Text);
        words.Add(cbWord3.Text);
        words.Add(cbWord4.Text);
        words.Add(cbWord5.Text);
        words.Add(cbWord6.Text);
        words.Add(cbWord7.Text);
        words.Add(cbWord8.Text);

        colours.Add(cbColor1.Text);
        colours.Add(cbColor2.Text);
        colours.Add(cbColor3.Text);
        colours.Add(cbColor4.Text);
        colours.Add(cbColor5.Text);
        colours.Add(cbColor6.Text);
        colours.Add(cbColor7.Text);
        colours.Add(cbColor8.Text);

        module = new ColorFlash(words, colours);
        module.Solve();
    }
}
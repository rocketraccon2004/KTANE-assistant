using KTANE_Assistant.Modules;
using btn = System.Windows.Forms.Button;
using Cell = KTANE_Assistant.Modules.Battleship.Cell;
using System.Linq;
using System.Diagnostics;
using System.Text;

#pragma warning disable CS8602 // Dereference of a possibly null reference.

namespace KTANE_Assistant.Forms;

public partial class frmBattleships : BaseForm
{
    private Battleship module;
    private List<Color> colours = [
        Color.Green,
        Color.Blue,
        Color.Red
        ];
    public frmBattleships(bool showButtons) : base(showButtons)
    {
        InitializeComponent();
        foreach (btn button in tableLayoutPanel1.Controls)
        {
            button.BackColor = colours[0];
        }
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(tbRow1.Text, out int row1) || !int.TryParse(tbRow2.Text, out int row2)
        || !int.TryParse(tbRow3.Text, out int row3) || !int.TryParse(tbRow4.Text, out int row4)
        || !int.TryParse(tbRow5.Text, out int row5))
        {
            Utils.throwError("One of the row numbers does not contain a number");
            return;
        }

        if (!int.TryParse(tbColumn1.Text, out int column1) || !int.TryParse(tbColumn2.Text, out int column2)
            || !int.TryParse(tbColumn3.Text, out int column3) || !int.TryParse(tbColumn4.Text, out int column4)
            || !int.TryParse(tbColumn5.Text, out int column5))
        {
            Utils.throwError("One of the column numbers does not contain a number");
            return;
        }

        int[] rows =
        [
            row1,
            row2,
            row3,
            row4,
            row5
        ];

        int[] columns =
        [
            column1,
            column2,
            column3,
            column4,
            column5
        ];

        if (!int.TryParse(tb1Ships.Text, out int ships1) || !int.TryParse(tb2Ships.Text, out int ships2)
            || !int.TryParse(tb3Ships.Text, out int ships3) || !int.TryParse(tb4Ships.Text, out int ships4))
        {
            Utils.throwError("One of the ship size inputs is not a number");
            return;
        }

        Color[,] gridColors = new Color[5, 5];

        foreach (btn b in tableLayoutPanel1.Controls)
        {
            int row = tableLayoutPanel1.GetRow(b);
            int column = tableLayoutPanel1.GetColumn(b);

            gridColors[column, row] = b.BackColor;
        }

        Cell[,] grid = new Cell[5, 5];

        for (int row = 0; row < 5; row++)
        {
            for (int column = 0; column < 5; column++)
            {
                Color c = gridColors[column, row];
                if (c == Color.Blue)
                {
                    grid[column, row] = Cell.Water;
                }
                else if (c == Color.Red)
                {
                    grid[column, row] = Cell.Ship;
                }
                else
                {
                    grid[column, row] = Cell.Unknown;
                }
            }
        }

        List<int> ships =
        [
            ships1,
            ships2,
            ships3,
            ships4
        ];

        grid = module.solve(rows, columns, grid, ships);

        for (int row = 0; row < 5; row++)
        {
            for (int column = 0; column < 5; column++)
            {
                Cell c = grid[column, row];
                if (c == Cell.Water)
                {
                    gridColors[column, row] = Color.Blue;
                }
                else if (c == Cell.Ship)
                {
                    gridColors[column, row] = Color.Red;
                }
            }
        }

        foreach (btn b in tableLayoutPanel1.Controls)
        {
            int row = tableLayoutPanel1.GetRow(b);
            int column = tableLayoutPanel1.GetColumn(b);
            b.BackColor = gridColors[column, row];
        }
    }

    private void frmBattleships_Load(object sender, EventArgs e)
    {
        module = new();
        Utils.showMessageBox(getRadar());
    }

    private string getRadar()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Radar: ");

        for (int i = 1; i < 4; i++)
        {
            char column;
            int row;
            try
            {
                column = Assistant.Instance.Bomb.getLetterInSerial(i);
                row = Assistant.Instance.Bomb.getDigitOfSerial(i);
            }
            catch (ArgumentOutOfRangeException)
            {
                break;
            }

            while (column > 'E')
            {
                column -= (char)5;
            }

            while (row > 5)
            {
                row -= 5;
            }

            if (row == 0)
            {
                row = 5;
            }

            sb.AppendLine($"({column}, {row})");
        }

        char column1 = Convert.ToChar(Assistant.Instance.Bomb.countPorts() + 64);
        int row1 = Assistant.Instance.Bomb.countLitIndicators() + Assistant.Instance.Bomb.countUnlitIndicators() + Assistant.Instance.Bomb.batteries;

        while (column1 > 'E')
        {
            column1 -= (char)5;
        }

        while (row1 > 5)
        {
            row1 -= 5;
        }

        if (column1 < 'A')
        {
            column1 = 'E';
        }

        if (row1 == 0)
        {
            row1 = 5;
        }

        sb.AppendLine($"({column1}, {row1})");

        return sb.ToString();
    }

    private void grid_button_click(object sender, EventArgs e)
    {
        btn b = (btn)sender;
        int currentColor = colours.IndexOf(b.BackColor);
        try
        {
            b.BackColor = colours[currentColor + 1];
        }
        catch (ArgumentOutOfRangeException)
        {
            b.BackColor = colours[0];
        }
    }

    private void txt_changed(object sender, EventArgs e)
    {
        TextBox tb = (TextBox)sender;
        if(tb != tb4Ships)
            Utils.getNextTB(tb, this).Select();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        foreach (Control c in tableLayoutPanel1.Controls)
        {
            c.BackColor = colours[0];
        }

        foreach (Control c in Controls)
        {
            if (c is TextBox)
            {
                c.Text = string.Empty;
            }
        }

        tbColumn1.Select();
    }
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.
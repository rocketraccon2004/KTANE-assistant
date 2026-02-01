using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTANE_Assistant.Modules;
using static KTANE_Assistant.Modules.Battleship;

namespace KTANE_Assistant.Tests
{
    [TestClass]
    public class BattleshipTests
    {
        [TestMethod]
        public void Solve_WithProvidedInputs_FindsAtLeastOneDefinitiveCell()
        {
            // Inputs from your message:
            // Columns: {2,1,2,2,1}
            // Rows:    {2,0,2,1,3}
            // Ships counts: {0,4,0,0} (counts for sizes 1..4)
            int[] columns = { 2, 1, 2, 2, 1 };
            int[] rows =    { 2, 0, 2, 1, 3 };
            var shipsCounts = new List<int> { 0, 4, 0, 0 };

            // Start with an unknown 5x5 grid (no pre-marked water/ship)
            var grid = new Cell[5, 5];
            for (int c = 0; c < 5; c++)
            {
                for (int r = 0; r < 5; r++)
                {
                    grid[c, r] = Cell.Unknown;
                }
            }

            var solver = new Battleship();
            Cell[,] result = solver.solve(rows, columns, grid, shipsCounts);

            // Verify the solver returned a grid with at least one definitive cell
            bool foundDefinitive = false;
            for (int c = 0; c < 5 && !foundDefinitive; c++)
            {
                for (int r = 0; r < 5; r++)
                {
                    if (result[c, r] != Cell.Unknown)
                    {
                        foundDefinitive = true;
                        break;
                    }
                }
            }

            Assert.IsTrue(foundDefinitive, "Solver returned no definitive cells (all Unknown). This usually means it found no valid placements or all placements disagree on every cell.");
        }
    }
}
using static KTANE_Assistant.Modules.Battleship;
using System.Diagnostics;
using System.Text;

namespace KTANE_Assistant.Modules;

public class Battleship : Module
{
    public Cell[,] solve(int[] rows, int[] columns, Cell[,] grid, List<int> ships)
    {
        const int N = 5;

        // Basic validation
        if (rows is null || columns is null || grid is null || ships is null) return grid;
        if (rows.Length != N || columns.Length != N) return grid;
        if (ships.Count < 4) return grid; // expecting counts for sizes 1..4

        // Expand counts into explicit ship sizes list (size 1..4)
        var shipSizes = new List<int>();
        for (int size = 1; size <= 4; size++)
        {
            int count = ships[size - 1];
            for (int k = 0; k < count; k++) shipSizes.Add(size);
        }

        // Masks from input grid: forbidden (water) and requiredShip (pre-marked ship cells)
        bool[,] forbidden = new bool[N, N];
        bool[,] requiredShip = new bool[N, N];
        for (int c = 0; c < N; c++)
        {
            for (int r = 0; r < N; r++)
            {
                forbidden[c, r] = grid[c, r] == Cell.Water;
                requiredShip[c, r] = grid[c, r] == Cell.Ship;
            }
        }

        var solutions = new List<bool[,]>();

        static bool HasAdjacent(bool[,] occ, int nc, int nr, int N)
        {
            for (int dc = -1; dc <= 1; dc++)
            {
                for (int dr = -1; dr <= 1; dr++)
                {
                    if (dc == 0 && dr == 0) continue;
                    int cc = nc + dc;
                    int rr = nr + dr;
                    if (cc >= 0 && cc < N && rr >= 0 && rr < N && occ[cc, rr]) return true;
                }
            }
            return false;
        }

        // Backtracking placement
        void PlaceShips(int index, bool[,] occ)
        {
            if (index >= shipSizes.Count)
            {
                // Validate row/column counts
                int[] rowCounts = new int[N];
                int[] colCounts = new int[N];
                for (int c = 0; c < N; c++)
                {
                    for (int r = 0; r < N; r++)
                    {
                        if (occ[c, r])
                        {
                            colCounts[c]++;
                            rowCounts[r]++;
                        }
                    }
                }

                for (int i = 0; i < N; i++)
                {
                    if (rowCounts[i] != rows[i]) return;
                    if (colCounts[i] != columns[i]) return;
                }

                // Ensure pre-marked ship cells are covered
                for (int c = 0; c < N; c++)
                {
                    for (int r = 0; r < N; r++)
                    {
                        if (requiredShip[c, r] && !occ[c, r]) return;
                    }
                }

                // Save solution copy
                var copy = new bool[N, N];
                for (int c = 0; c < N; c++) for (int r = 0; r < N; r++) copy[c, r] = occ[c, r];
                solutions.Add(copy);
                return;
            }

            int size = shipSizes[index];

            // Try horizontal placements
            for (int r = 0; r < N; r++)
            {
                for (int cStart = 0; cStart <= N - size; cStart++)
                {
                    bool ok = true;
                    // Check cells are available and not forbidden/occupied
                    for (int k = 0; k < size && ok; k++)
                    {
                        int c = cStart + k;
                        if (forbidden[c, r] || occ[c, r]) ok = false;
                    }
                    if (!ok) continue;

                    // Check adjacency to existing occupied cells
                    for (int k = 0; k < size && ok; k++)
                    {
                        int c = cStart + k;
                        if (HasAdjacent(occ, c, r, N)) ok = false;
                    }
                    if (!ok) continue;

                    // Place
                    for (int k = 0; k < size; k++) occ[cStart + k, r] = true;

                    // Quick prune: do not exceed row/col counts
                    bool countsOk = true;
                    for (int rr = 0; rr < N && countsOk; rr++)
                    {
                        int curRowCount = 0;
                        for (int cc = 0; cc < N; cc++) if (occ[cc, rr]) curRowCount++;
                        if (curRowCount > rows[rr]) countsOk = false;
                    }
                    for (int cc = 0; cc < N && countsOk; cc++)
                    {
                        int curColCount = 0;
                        for (int rr = 0; rr < N; rr++) if (occ[cc, rr]) curColCount++;
                        if (curColCount > columns[cc]) countsOk = false;
                    }

                    if (countsOk) PlaceShips(index + 1, occ);

                    // Unplace
                    for (int k = 0; k < size; k++) occ[cStart + k, r] = false;
                }
            }

            for (int c = 0; c < N; c++)
            {
                for (int rStart = 0; rStart <= N - size; rStart++)
                {
                    bool ok = true;
                    for (int k = 0; k < size && ok; k++)
                    {
                        int r = rStart + k;
                        if (forbidden[c, r] || occ[c, r]) ok = false;
                    }
                    if (!ok) continue;

                    for (int k = 0; k < size && ok; k++)
                    {
                        int r = rStart + k;
                        if (HasAdjacent(occ, c, r, N)) ok = false;
                    }
                    if (!ok) continue;

                    for (int k = 0; k < size; k++) occ[c, rStart + k] = true;

                    bool countsOk = true;
                    for (int rr = 0; rr < N && countsOk; rr++)
                    {
                        int curRowCount = 0;
                        for (int cc = 0; cc < N; cc++) if (occ[cc, rr]) curRowCount++;
                        if (curRowCount > rows[rr]) countsOk = false;
                    }
                    for (int cc = 0; cc < N && countsOk; cc++)
                    {
                        int curColCount = 0;
                        for (int rr = 0; rr < N; rr++) if (occ[cc, rr]) curColCount++;
                        if (curColCount > columns[cc]) countsOk = false;
                    }

                    if (countsOk) PlaceShips(index + 1, occ);

                    for (int k = 0; k < size; k++) occ[c, rStart + k] = false;
                }
            }
        }

        var occStart = new bool[N, N];
        PlaceShips(0, occStart);

        int solutionCount = solutions.Count;

        if (solutionCount == 0)
        {
            Utils.throwError("No Solutions found");
            return grid;
        }

        var result = new Cell[N, N];
        for (int c = 0; c < N; c++)
        {
            for (int r = 0; r < N; r++)
            {
                int occCount = 0;
                foreach (var sol in solutions) if (sol[c, r]) occCount++;
                if (occCount == solutions.Count) result[c, r] = Cell.Ship;
                else if (occCount == 0) result[c, r] = Cell.Water;
                else result[c, r] = Cell.Unknown;
            }
        }

        return result;
    }

    public enum Cell
    {
        Unknown,
        Water,
        Ship
    }
}
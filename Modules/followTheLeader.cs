using System.Linq;

namespace KTANE_Assistant.Modules;

public class followTheLeader(string colours, string numbers) : Module
{
    private string colours = colours.ToLower();

    private List<string> coloursList = new();
    private char currentInstruction;
    private string numbers = numbers.ToLower();
    private List<int> numbersList = new();
    private bool reverse;
    private int start;
    private List<int> toCut;

    public void Solve()
    {
        toCut = new List<int>();
        coloursList = colours.Split(',').ToList();
        var temp = numbers.Split(',');

        foreach (var s in temp)
        {
            if (!int.TryParse(s, out var number))
            {
                throwError($"Not a number: {s}");
                return;
            }

            numbersList.Add(number);
        }

        start = determineStartPos();

        if (start == 1000)
        {
            MessageBox.Show("Cut all wires in decending order");
            return;
        }

        var startIndex = numbersList.IndexOf(start);

        numbersList = ReorderList(numbersList, start);

        var startColor = coloursList[startIndex];

        coloursList = ReorderList(coloursList, startIndex);

        currentInstruction = bomb.getLetterInSerial(1);
        reverse = startColor == "r" || startColor == "g" || startColor == "w";


        foreach (var i in numbersList)
        {
            if (i == start)
            {
                toCut.Add(i);
                continue;
            }

            if (cutWire(i)) toCut.Add(i);

            if (reverse)
            {
                if (currentInstruction == 'A')
                    currentInstruction = 'Z';
                else
                    currentInstruction--;
            }
            else
            {
                if (currentInstruction == 'Z')
                    currentInstruction = 'A';
                else
                    currentInstruction++;
            }
        }

        MessageBox.Show($"Cut wires {string.Join(", ", toCut)}");
    }

    private int determineStartPos()
    {
        if (numbersList.Contains(4) && numbersList.Contains(5) && bomb.hasPort(Port.rj45)) return 4;

        if (numbersList.Contains(bomb.batteries)) return bomb.batteries;

        if (numbersList.Contains(bomb.getDigitOfSerial(1))) return bomb.getDigitOfSerial(1);

        if (bomb.hasIndicator(IndicatorType.CLR, true)) return 1000;

        return numbersList.Min();
    }

    private bool cutWire(int wire)
    {
        var index = numbersList.IndexOf(wire);

        switch (currentInstruction)
        {
            case 'A':
            case 'N':
                return getWireColorByIndex(index - 1) != "y" ||
                       getWireColorByIndex(index - 1) != "g" ||
                       getWireColorByIndex(index - 1) != "b";
            case 'B':
            case 'O':
                return !isOdd(wire);
            case 'C':
            case 'P':
                return toCut.Contains(getWireNumberByIndex(index - 1));
            case 'D':
            case 'Q':
                return getWireColorByIndex(index - 1) == "r" &&
                       getWireColorByIndex(index - 1) == "blk" &&
                       getWireColorByIndex(index - 1) == "b";

            case 'E':
            case 'R':
                return getWireColorByIndex(index - 1) == getWireColorByIndex(index - 2) ||
                       getWireColorByIndex(index - 1) == getWireColorByIndex(index - 3) ||
                       getWireColorByIndex(index - 2) == getWireColorByIndex(index - 3);
            case 'F':
            case 'S':
                return (getWireColorByIndex(index) == getWireColorByIndex(index - 1) ||
                        getWireColorByIndex(index) == getWireColorByIndex(index - 2)) &&
                       !(getWireColorByIndex(index) == getWireColorByIndex(index - 1) &&
                         getWireColorByIndex(index) == getWireColorByIndex(index - 2));
            case 'G':
            case 'T':
                return getWireColorByIndex(index - 1) == "y" ||
                       getWireColorByIndex(index - 1) == "w" ||
                       getWireColorByIndex(index - 1) == "g";
            case 'H':
            case 'U':
                return !toCut.Contains(getWireNumberByIndex(index - 1));
            case 'I':
            case 'V':
                return getWireNumberByIndex(index - 1) + 1 != wire;
            case 'J':
            case 'W':
                return getWireColorByIndex(index - 1) != "blk" &&
                       getWireColorByIndex(index - 1) != "w" &&
                       getWireColorByIndex(index - 1) != "r";
            case 'K':
            case 'X':
                return getWireColorByIndex(index - 1) != getWireColorByIndex(index - 2);
            case 'L':
            case 'Y':
                return wire > 6;
            case 'M':
            case 'Z':
                var wire1 = getWireColorByIndex(index - 1);
                var wire2 = getWireColorByIndex(index - 2);
                if (areWiresUnique(wire1, wire2))
                {
                    if ((wire1 == "blk" || wire1 == "w") && (wire1 == "blk" || wire1 == "w")) return false;
                    return true;
                }

                return false;
        }

        return false;
    }

    private bool areWiresUnique(string wire1, string wire2)
    {
        return wire1 != wire2;
    }

    private int getWireNumberByIndex(int index)
    {
        var count = numbersList.Count;

        if (count == 0)
            throwError("List cannot be empty.");

        index = (index % count + count) % count;

        return numbersList[index];
    }

    private string getWireColorByIndex(int index)
    {
        var count = coloursList.Count;

        if (count == 0)
            throwError("List cannot be empty.");

        index = (index % count + count) % count;

        return coloursList[index];
    }

    public static List<int> ReorderList(List<int> list, int value)
    {
        var index = list.IndexOf(value);

        if (index != -1)
        {
            var reorderedList = new List<int>(list.GetRange(index, list.Count - index));

            reorderedList.AddRange(list.GetRange(0, index));

            list.Clear();
            list.AddRange(reorderedList);
        }

        return list;
    }

    public static List<string> ReorderList(List<string> list, int index)
    {
        if (index != -1)
        {
            var reorderedList = new List<string>(list.GetRange(index, list.Count - index));

            reorderedList.AddRange(list.GetRange(0, index));

            list.Clear();
            list.AddRange(reorderedList);
        }

        return list;
    }
}
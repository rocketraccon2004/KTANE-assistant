using KTANE_Assistant.Forms;
using KTANE_Assistant.Modules;

namespace KTANE_Assistant
{
    public static class ModuleSelector
    {
        public static readonly Dictionary<string, Func<Form>> ModuleFactories = new()
        {
            { "3D Maze", () =>  dMaze ??= new frm3dMaze(true)},
            { "Adjacent Letters", () => adjacentLetters ??= new frmAdjacentLetters(true) },
            { "Adventure Game", () => adventureGame ??= new frmAdventureGame(true) },
            { "Alphabet", () => alphabet ??= new frmAlphabet(true) },
            { "Anagrams", () => anagrams ??= new frmAnagrams(true) },
            { "Astrology", () => Astrology ??= new frmAstrology(true) },
            { "Battleship", () => battleship ??= new frmBattleships(true) },
            { "Bitmaps", () => bitmaps ??= new frmBitmaps(true) },
            { "Binary LEDs", () => BinaryLEDs ??= new frmBinaryLEDs(true) },
            { "Blind Alley", () => blindAlley ??= new frmBlindAlley() },
            { "Button", () => button ??= new frmButton(true) },
            { "Complicated Wires", () => complicatedWires ??= new frmComplicatedWires(true) },
            { "Color Flash", () => colourFlash ??= new frmColorFlash(true) },
            { "Edgework Input", () => edgeworkInput ??= new frmEdgeworkInput(false) },
            { "Follow the Leader", () => followTheLeader ??= new frmFollowTheLeader(true) },
            { "Keypads", () => keypads ??= new frmKeypads(true) },
            { "Knobs", () => knob ??= new frmKnob(true) },
            { "LED Encryption", () => LEDEncryption ??= new frmLEDEncryption(true) },
            { "Maze", () => maze ??= new frmMaze(true) },
            { "Memory", () => memory ??= new frmMemory(true) },
            { "Passwords", () => password ??= new frmPassword(true) },
            { "Simon Says", () => simonSays ??= new frmSimon(true) },
            { "Wires", () => wires ??= new frmWires(true) },
            { "Wire Sequences", () => wireSequences ??= new frmWireSequences(true) },
            { "Skewed Slots", () => skewedSlots ??= new frmSkewedSlots(true) },
            { "Who's On First", () => whosOnFirst ??= new frmWhosOnFirst(true) }
        };

        // Cached Instances
        private static frm3dMaze? dMaze;
        private static frmAdjacentLetters? adjacentLetters;
        private static frmAdventureGame? adventureGame;
        private static frmAlphabet? alphabet;
        private static frmAnagrams? anagrams;
        private static frmBattleships? battleship;
        private static frmBlindAlley? blindAlley;
        private static frmButton? button;
        private static frmComplicatedWires? complicatedWires;
        private static frmColorFlash? colourFlash;
        private static frmEdgeworkInput? edgeworkInput;
        private static frmFollowTheLeader? followTheLeader;
        private static frmKeypads? keypads;
        private static frmKnob? knob;
        private static frmLEDEncryption? LEDEncryption;
        private static frmMaze? maze;
        private static frmMemory? memory;
        private static frmPassword? password;
        private static frmSimon? simonSays;
        private static frmWires? wires;
        private static frmWireSequences? wireSequences;
        private static frmSkewedSlots? skewedSlots;
        private static frmWhosOnFirst? whosOnFirst;
        private static frmAstrology? Astrology;
        private static frmBinaryLEDs? BinaryLEDs;
        private static frmBitmaps bitmaps;

        public static Form? SelectForm(string module)
        {
            if (ModuleFactories.TryGetValue(module, out var formFactory))
            {
                return formFactory();
            }
            Utils.throwError("Module either NYI or Doesn't exist");
            return null;
        }
    }

}

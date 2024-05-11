using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EightPuzzle;
using static System.Windows.Forms.AxHost;

namespace EightPuzzle
{
    public static class Utils
    {
        public enum Moves { Up, Down, Left, Right, Dummy }
        public enum Difficulty { Easy, Medium, Hard };

        public static StateNode dummyNode = new StateNode(new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }, -1, new int[] { -1, -1 }, Utils.Moves.Up);
        
        public static Logger logger = new Logger();
        public static bool isValidIdx(int[] idx)
        {
            return (idx[0] >= 0 && idx[0] < 3 && idx[1] >= 0 && idx[1] < 3);
        }

        public static bool isDummyNode(StateNode node)
        {
            return (node == dummyNode);
        }
    }
}

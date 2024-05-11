using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    public class StateNode
    {
        public int[,] state;
        public int heuristic;
        public int[] prevIdx;
        public int[] zeroIdx = new int[] { -1, -1 };
        public Utils.Moves move;
        public StateNode(int[,] state, int heuristic, int[] prevIdx, Utils.Moves move)
        {
            this.state = state;
            this.heuristic = heuristic;
            this.prevIdx = prevIdx;
            this.move = move;

            for (int row = 0; row < state.GetLength(0); row++)
            {
                for (int col = 0; col < state.GetLength(1); col++)
                {
                    if (state[row, col] == 0)
                    {
                        this.zeroIdx = new int[] { row, col };
                        break;
                    }
                }
            }
        }
    }
}

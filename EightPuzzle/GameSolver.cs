using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    public class GameSolver
    {
        private Game game;
        private IDictionary<Utils.Moves, Action<int[]>> MoveActionMapping;
        private int[][] cMoves = { };
        private int sleepTimeMs = 250;
        private Search.Algorithms searchAlgorithm;
        public GameSolver(Game game, Search.Algorithms searchAlgorithm) { 
            this.game = game;
            this.searchAlgorithm = searchAlgorithm;

            MoveActionMapping = new Dictionary<Utils.Moves, Action<int[]>> {
                { Utils.Moves.Up, (idx) => {
                    game.swapIdx(idx, new int[] { idx[0] - 1, idx[1] }); }
                },
                { Utils.Moves.Down, (idx) => {
                    game.swapIdx(idx, new int[] { idx[0] + 1, idx[1] }); }
                },
                { Utils.Moves.Left, (idx) => {
                    game.swapIdx(idx, new int[] { idx[0], idx[1] - 1 }); }
                },
                { Utils.Moves.Right, (idx) => {
                    game.swapIdx(idx, new int[] { idx[0], idx[1] + 1 }); }
                },
            };
        }

        public bool solve()
        {
            if (this.searchAlgorithm == Search.Algorithms.Astar)
            {
                Search.Astar astar = new Search.Astar(game.getCurrentState(), game);
                int[][] solution = astar.SearchAndGetSolution();
                if (solution[0][0] == -1) return false;
                this.updateMoves(solution);
            }
            return true;
        }
        public void updateMoves(int[][] cMoves) { 
            this.cMoves = cMoves;
        }

        public void executeMoves()
        {
            foreach(int[] move in cMoves){
                Utils.Moves dir = (Utils.Moves)move[2];
                int[] idx = new int[] { move[0], move[1] };
                Utils.logger.log("Executing the move " + dir.ToString() + " on position (" + String.Join(", ", idx) + ")", "GameSolver.executeMoves()");
                MoveActionMapping[dir](idx);
                Thread.Sleep(sleepTimeMs);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    public class GameShuffler
    {
        private IDictionary<Utils.Moves, Action> MoveActionMapping;

        private Game game;
        private int[,] state;
        private int[] zeroIdx;
        private Utils.Difficulty difficulty;
        public GameShuffler(Game game, Utils.Difficulty difficulty) {
            this.game = game;
            this.state = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
            this.zeroIdx = new int[] { 2, 2 };
            this.difficulty = difficulty;
            this.MoveActionMapping = new Dictionary<Utils.Moves, Action> {
                { Utils.Moves.Up, () => { moveUp(); } },
                { Utils.Moves.Down, () => { moveDown(); } },
                { Utils.Moves.Left, () => { moveLeft(); } },
                { Utils.Moves.Right, () => { moveRight(); } }
            };
        }

        private int[] getShuffledState()
        {
            this.state = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
            shuffle(this.difficulty);
            return this.state.Cast<int>().ToArray();
        }

        public void shuffleGame()
        {
            int[] shuffledState = getShuffledState();
            Utils.logger.log("setting state to the shuffled state: { " + String.Join(" ", shuffledState) + " }", "GameShuffler.shuffleGame");
            int z = 0;
            for (int row = 0; row < this.game.state.GetLength(0); row++)
            {
                for (int col = 0; col < this.game.state.GetLength(1); col++)
                {
                    if (shuffledState[z] == 0)
                    {
                        this.game.state[row, col].Text = "";
                        z++;
                        continue;
                    }
                    this.game.state[row, col].Text = shuffledState[z++].ToString();
                }
            }
        }

        private void shuffle(Utils.Difficulty difficulty)
        {
            Utils.logger.log("Shuffling state", "[GameShuffler.shuffle]");
            Random rnd = new Random();
            int nMoves = 0;
            
            if (difficulty == Utils.Difficulty.Easy) nMoves = rnd.Next(50,70);
            if (difficulty == Utils.Difficulty.Medium) nMoves = rnd.Next(70, 100);
            if (difficulty == Utils.Difficulty.Hard) nMoves = rnd.Next(100, 150);

            Utils.logger.log("Shuffling with " + nMoves.ToString() + " random moves", "GameShuffler.shuffle()");

            for (int i = 0; i < nMoves; i++)
            {
                Utils.Moves randMove;
                do
                {
                    if (i % 2 == 0)
                    {
                        randMove = (Utils.Moves)rnd.Next(0, 2);
                    }
                    else
                    {
                        randMove = (Utils.Moves)rnd.Next(2, 4);
                    }
                } while (!isValidMove(randMove));
                Utils.logger.log("Executing the move " + randMove.ToString() + " on position (" + String.Join(", ", zeroIdx) + ")", "GameShuffler.shuffle");
                MoveActionMapping[randMove]();
            }
        }

        private bool isValidMove(Utils.Moves move)
        {

            if (move == Utils.Moves.Up) return zeroIdx[0] > 0;
            if (move == Utils.Moves.Down) return zeroIdx[0] < 2;
            if (move == Utils.Moves.Left) return zeroIdx[1] > 0;
            if (move == Utils.Moves.Right) return zeroIdx[1] < 2;

            return false;
        }

        private void swapIdx(int[] idx1, int[] idx2)
        {
            int tmp = state[idx1[0], idx1[1]];
            state[idx1[0], idx1[1]] = state[idx2[0], idx2[1]];
            state[idx2[0], idx2[1]] = tmp;
        }
        private void moveUp()
        {
            int[] newIdx = new int[] { zeroIdx[0] - 1, zeroIdx[1] };
            swapIdx(zeroIdx, newIdx);
            zeroIdx = newIdx;
        }

        private void moveDown()
        {
            int[] newIdx = new int[] { zeroIdx[0] + 1, zeroIdx[1] };
            swapIdx(zeroIdx, newIdx);
            zeroIdx = newIdx;
        }

        private void moveLeft()
        {
            int[] newIdx = new int[] { zeroIdx[0], zeroIdx[1] - 1};
            swapIdx(zeroIdx, newIdx);
            zeroIdx = newIdx;
        }

        private void moveRight()
        {
            int[] newIdx = new int[] { zeroIdx[0], zeroIdx[1] + 1};
            swapIdx(zeroIdx, newIdx);
            zeroIdx = newIdx;
        }
    }
}

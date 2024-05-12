using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    public class Game
    {
        public GameButton[,] state = new GameButton[3,3];
        public TextBox nmovesTxtBx;
        public TextBox statusTxt;

        public Game(GameButton[] gameButtons, TextBox nmovesTxtBx, TextBox statusTxt) {
            this.nmovesTxtBx = nmovesTxtBx;
            this.statusTxt = statusTxt;
            initializeState(gameButtons);
        }

        private void initializeState(GameButton[] gameButtons)
        {
            int c = 0;
            for (int row = 0; row < state.GetLength(0); row++)
            {
                for (int col = 0; col < state.GetLength(1); col++)
                {
                    state[row, col] = gameButtons[c++];
                    state[row, col].idx[0] = row;
                    state[row, col].idx[1] = col;
                }
            }
        }

        public int[,] getCurrentState()
        {
            int[,] state__ = new int[3, 3];
            for (int row = 0; row < state.GetLength(0); row++)
            {
                for (int col = 0; col < state.GetLength(1); col++)
                {
                    if (state[row, col].Text == "")
                    {
                        state__[row, col] = 0;
                    }
                    else
                    {
                        state__[row, col] = Convert.ToInt32(state[row, col].Text);
                    }
                }
            }

            return state__;
        }

        public void shuffle(Utils.Difficulty difficulty)
        {
            GameShuffler shuffler = new GameShuffler(this, difficulty);
            shuffler.shuffleGame();
            nmovesTxtBx.Text = "0";
            statusTxt.Text = "Ready";
        }

        private int[] getEmptyIdx(GameButton btn)
        {
            int row = btn.idx[0];
            int col = btn.idx[1];

            // up down left right
            int[][] directions = { new int[] { row - 1, col }, new int []{ row + 1, col }, new int []{ row, col - 1 }, new int []{ row, col + 1 } };

            foreach (int[] direction in directions)
            {
                if (Utils.isValidIdx(direction))
                {
                    if (state[direction[0], direction[1]].Text == "") return direction;
                }
            }

            return new int []{ -1, -1};

        }

        public void swapIdx(int[] idx1, int[] idx2)
        {
            string tmp = state[idx1[0], idx1[1]].Text;
            state[idx1[0], idx1[1]].Text = state[idx2[0], idx2[1]].Text;
            state[idx2[0], idx2[1]].Text = tmp;
            nmovesTxtBx.Text = ((Convert.ToInt32(nmovesTxtBx.Text)) + 1).ToString();
        }

        public void handleClick(object sender, EventArgs e)
        {
            GameButton btn = (GameButton)sender;
            int[] x = getEmptyIdx(btn);
            if (x[0] != -1)
            {
                swapIdx(x, new int []{ btn.idx[0], btn.idx[1] });
            }
        }
    }
}
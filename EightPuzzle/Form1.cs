using System;
using System.Runtime.CompilerServices;

namespace EightPuzzle
{
    public partial class Form1 : Form
    {
        public Game game;
        public Utils.Difficulty difficulty = Utils.Difficulty.Easy;
        public Search.Algorithms searchAlgorithm = Search.Algorithms.Astar;
        public Form1()
        {
            InitializeComponent();
            GameButton[] buttons = { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            game = new Game(buttons, nmovesTextBox, statusTxt);
            this.MaximizeBox = false;
            Utils.logger.setTextBox(logTextBox);
            Utils.logger.disable();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void game_btn_click(object sender, EventArgs e)
        {
            game.handleClick(sender, e);
        }

        private void shuffle_btn_click(object sender, EventArgs e)
        {
            Utils.logger.log("Shuffling board", "Form");
            game.shuffle(this.difficulty);
        }

        private async void solve_btn_click(object sender, EventArgs e)
        {
            Utils.logger.log("Solving board", "Form");
            nmovesTextBox.Text = "0";
            await Task.Factory.StartNew(() => SolverTask.doWork(game, statusTxt, this.searchAlgorithm),
                                 TaskCreationOptions.LongRunning);
        }

        class SolverTask
        {
            public static void doWork(Game game, TextBox statusTxt, Search.Algorithms searchAlgorithm)
            {
                statusTxt.Text = "Searching for solution";
                Utils.logger.log("Searching for solution", "SolverTask.doWork()");
                GameSolver gsolver = new GameSolver(game, searchAlgorithm);
                bool solved = gsolver.solve();
                if (!solved)
                {
                    statusTxt.Text = "Can't find a solution";
                    Utils.logger.log("Couldn't find a solution", "SolverTask.doWork()");
                    return;
                }
                statusTxt.Text = "Executing solution";
                Utils.logger.log("Executing solution", "SolverTask.doWork()");
                gsolver.executeMoves();
                statusTxt.Text = "Ready";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.logger.clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobtn = (RadioButton)sender;
            if (radiobtn.Checked)
            {
                this.difficulty = Utils.Difficulty.Easy;
                Utils.logger.log("Difficulty changed to Easy", "Form");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobtn = (RadioButton)sender;
            if (radiobtn.Checked)
            {
                this.difficulty = Utils.Difficulty.Medium;
                Utils.logger.log("Difficulty changed to Medium", "Form");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobtn = (RadioButton)sender;
            if (radiobtn.Checked)
            {
                this.difficulty = Utils.Difficulty.Hard;
                Utils.logger.log("Difficulty changed to Hard", "Form");
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobtn = (RadioButton)sender;
            if (radiobtn.Checked)
            {
                Utils.logger.enable();
                Utils.logger.log("Log enabled", "Form");
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobtn = (RadioButton)sender;
            if (radiobtn.Checked)
            {
                Utils.logger.log("Log disabled", "Form");
                Utils.logger.disable();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobtn = (RadioButton)sender;
            if (radiobtn.Checked)
            {
                this.searchAlgorithm = Search.Algorithms.Astar;
                Utils.logger.log("Algorithm was set to A*", "Form");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    public static class Search
    {
        public enum Algorithms
        {
            Astar
        };
        public class Astar
        {
            private int[,] initState;

            private int maxIter = 5000;

            private PriorityQueue<StateNode, int> front;

            private IDictionary<string, StateNode> visited = new Dictionary<string, StateNode>();
            private List<int[]> solution = new List<int[]>();

            Game game;

            public Astar(int[,] initState, Game game) {
                this.initState = initState;
                this.game = game;
                this.front = new PriorityQueue<StateNode, int>();
            }

            private bool stateIsVisited(StateNode node)
            {
                string state = String.Join("", node.state.Cast<int>().ToArray());

                foreach (KeyValuePair<string, StateNode> entry in visited)
                {
                    if (Enumerable.SequenceEqual(entry.Key, state)) return true;
                }

                return false;
            }

            private void markStateAsVisited(StateNode state, StateNode prev)
            {
                visited[String.Join("", state.state.Cast<int>().ToArray())] = prev;
                return;
            }

            private StateNode Search()
            {
                StateNode init = new StateNode(this.initState, heuristic(this.initState), new int[] { -1, -1 }, Utils.Moves.Up);
                front.Enqueue(init, init.heuristic);
                markStateAsVisited(init, Utils.dummyNode);
                StateNode current = Utils.dummyNode;

                int curIter = 0;

                while (front.Count > 0)
                {
                    if (curIter > maxIter)
                    {
                        return Utils.dummyNode;
                    }

                    curIter++;

                    current = front.Dequeue();
                    if (isGoalState(current.state))
                    {
                        break;
                    }

                    Utils.logger.log("Expanding state { " + String.Join(" ", current.state.Cast<int>().ToArray()) + " }", "Search.Astar.Search()");

                    StateNode[] successors = getSuccessors(current);

                    foreach (StateNode successor in successors)
                    {
                        if (!stateIsVisited(successor))
                        {
                            markStateAsVisited(successor, current);
                            front.Enqueue(successor, successor.heuristic);
                        }
                    }
                }
                return current;
            }

            private StateNode[] getSuccessors(StateNode node)
            {
                int[] idx = node.zeroIdx;
                int row = idx[0];
                int col = idx[1];

                List<StateNode> successors = new List<StateNode>();

                // up down left right
                int[][] directions = { new int[] { row - 1, col }, new int[] { row + 1, col }, new int[] { row, col - 1 }, new int[] { row, col + 1 } };

                for (int i = 0; i < directions.Length; i++)
                {
                    if (Utils.isValidIdx(directions[i]))
                    {
                        int[,] tmp = (int[,]) node.state.Clone();
                        int[,] newState = swapIdx(tmp, idx, directions[i]);
                        successors.Add(new StateNode(newState, heuristic(newState), idx, (Utils.Moves)i));
                    }
                }

                return successors.ToArray();
            }

            private int[,] swapIdx(int[,] state, int[] idx1, int[] idx2)
            {
                int tmp = state[idx1[0], idx1[1]];
                state[idx1[0], idx1[1]] = state[idx2[0], idx2[1]];
                state[idx2[0], idx2[1]] = tmp;

                return state;
            }

            private int[][] getSolution(StateNode node)
            {
                List<StateNode> solution = new List<StateNode>();
                solution.Add(node);

                StateNode cur = visited[String.Join("", node.state.Cast<int>().ToArray())];

                while(!Utils.isDummyNode(cur))
                {
                    solution.Add(cur);
                    cur = visited[String.Join("", cur.state.Cast<int>().ToArray())];
                }

                solution.Reverse();
                List<int[]> sol = new List<int[]>();

                foreach(StateNode node__ in solution)
                {
                    int[] prevIdx = node__.prevIdx;
                    if (prevIdx[0] == -1) continue;
                    sol.Add(new int[] { prevIdx[0], prevIdx[1], (int)node__.move });
                }

                return sol.ToArray();

            }

            public int[][] SearchAndGetSolution()
            {
                StateNode final = Search();
                if (final.prevIdx[0] == -1)
                {
                    return new int[][] { new int[] { -1,-1,-1 } };
                }
                return getSolution(final);
            }

            private bool isGoalState(int[,] state)
            {
                return heuristic(state) == 0;
            }

            private int heuristic(int[,] state)
            {
                int c = 1;
                int heur = 0;

                for (int row = 0; row < state.GetLength(0); row++)
                {
                    for (int col = 0; col < state.GetLength(1); col++)
                    {
                        if (c == 9)
                        {
                            if (state[row, col] != 0) heur++;
                            continue;
                        }
                        if (state[row, col] != c) heur++;

                        c++;
                    }
                }

                return heur;
            }
        }
    }
}

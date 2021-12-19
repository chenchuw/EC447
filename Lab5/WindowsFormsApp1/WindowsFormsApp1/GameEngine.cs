using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class GameEngine
    {
        class Move
        {
            public int row, col;
        };

        public const float linelength = 80;
        public const float block = linelength / 3;
        private const float delta = 5;
        public char[,] grid = new char[3, 3];

        public bool gameover;
        public bool tie;
        public bool user_win;
        public bool computer_win;
        public bool computer_firstmove;
        public bool computer_turn;
        public int turn_count;

        public GameEngine()
        {
            turn_count = 0;
            gameover = false;
            computer_turn = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 'N';
                }
            }
        }

        public void UserTurn(MouseEventArgs e, PointF[] p, GameEngine game)
        {
            if (p[0].X < 0 || p[0].Y < 0)
                return;
            int i = (int)(p[0].X / block);
            int j = (int)(p[0].Y / block);
            if (i > 2 || j > 2)
                return;
            if (gameover)
                return;
            else if (!gameover && !computer_turn)
            {
                if ((grid[i, j] == 'N'))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        grid[i, j] = 'X';
                        this.turn_count++;
                        this.computer_turn = true;
                        this.judge(grid);
                        this.CompTurn(game);
                    }
                }
                else
                    MessageBox.Show("This cell is occupied!");
            }
        }

        public void CompTurn(GameEngine game)
        {

            bool userMove = false;
            if (gameover)
            {
                computer_turn = false;
                judge(grid);
                return;
            }
            else if (!computer_firstmove && !gameover)
            {
                if (userMove)
                {
                    computer_turn = false;
                    return;
                }
                Move newMove = new Move();
                newMove = findBestMove(grid);
                grid[newMove.row, newMove.col] = 'O';
                userMove = true;
                computer_turn = false;
                this.turn_count++;
                judge(grid);
                return;
            }
            
            else if (computer_firstmove && !gameover)
            {
                Random start = new Random();
                int i = start.Next(0, 3);
                int j = start.Next(0, 3);
                grid[i, j] = 'O';
                userMove = true;
                computer_turn = false;
                computer_firstmove = false;
                game.turn_count++;
                judge(grid);
                return;
            }
            else if (gameover)
                return;
        }

        public void judge(char[,] grid)
        {
            // check row victory
            for (int row = 0; row <= 2; row++)
            {
                if (grid[row, 0] == grid[row, 1] && grid[row, 1] == grid[row, 2])
                {
                    if (grid[row, 0] == 'X') {
                        gameover = true;
                        MessageBox.Show("You Win!");
                    }
                        
                    else if (grid[row, 0] == 'O') {
                        gameover = true;
                        MessageBox.Show("You Lose!");
                    }
                        
                }
            }

            // check column victory
            for (int col = 0; col <= 2; col++)
            {
                if (grid[0, col] == grid[1, col] && grid[1, col] == grid[2, col])
                {
                    if (grid[0, col] == 'X') {
                        gameover = true;
                        MessageBox.Show("You Win!");
                    }
                    else if (grid[0, col] == 'O') {
                        gameover = true;
                        MessageBox.Show("You Lose!");
                    }
                       
                }
            }

            // check diagnol victory
            if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2])
            {
                if (grid[0, 0] == 'X') {
                    gameover = true;
                    MessageBox.Show("You Win!");
                }
                else if (grid[0, 0] == 'O') {
                    gameover = true;
                    MessageBox.Show("You Lose!");
                }
                    
            }

            if (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0])
            {
                if (grid[0, 2] == 'X') {
                    gameover = true;
                    MessageBox.Show("You Win!");
                }
                else if (grid[0, 2] == 'O') {
                    gameover = true;
                    MessageBox.Show("You Lose!");
                }
                    
            }

            // check tie
            if (turn_count == 9 && !gameover)
            {
                tie = true;
                MessageBox.Show("Tie!");
                gameover = true;
            }

            else
                return;
        }
        Move findBestMove(char[,] grid)
        {
            int best_val = -1000;
            Move best_move = new Move();

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (grid[i, j] == 'N')
                    {
                        // predict comp move here and check the bestvalue
                        grid[i, j] = 'O';
                        int moveVal = minimax(grid, 0, true);
                        grid[i, j] = 'N';
                        if (moveVal > best_val)
                        {
                            best_move.row = i;
                            best_move.col = j;
                            best_val = moveVal;
                        }
                    }
                }
            }
            return best_move;
        }

        // minimax algorithm implemented here
        public int minimax(char[,] grid, int count, Boolean who)
        {
            int score = find_score(grid);

            if (score == 10 || score == -10)
                return score;

            // if no more moves then tie
            if (Moves_left(grid) == false)
                return 0;

            if (who)
            {
                // Predict Player Move
                int best = 100;
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (grid[i, j] == 'N')
                        {
                            grid[i, j] = 'X';
                            best = Math.Min(best, this.minimax(grid, count + 1, !who));
                            grid[i, j] = 'N';
                        }
                    }
                }
                return best + count; // To find the fastest way to win
            }

            else
            {
                // Predict Computer Move
                int best = -100;
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (grid[i, j] == 'N')
                        {
                            grid[i, j] = 'O';
                            best = Math.Max(best, this.minimax(grid, count + 1, !who)) ;
                            grid[i, j] = 'N';
                        }
                    }
                }
                return best - count; // To find the fastest way to win
            }
        }
        static Boolean Moves_left(char[,] grid)
        {
            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 2; j++)
                    if (grid[i, j] == 'N')
                        return true;
            return false;
        }
        static int find_score(char[,] b)
        {
            // check row victory
            for (int row = 0; row <= 2; row++)
            {
                if (b[row, 0] == b[row, 1] &&
                    b[row, 1] == b[row, 2])
                {
                    if (b[row, 0] == 'O')
                        return +10;
                    else if (b[row, 0] == 'X')
                        return -10;
                }
            }

            // check column victory
            for (int col = 0; col <= 2; col++)
            {
                if (b[0, col] == b[1, col] &&
                    b[1, col] == b[2, col])
                {
                    if (b[0, col] == 'O')
                        return +10;

                    else if (b[0, col] == 'X')
                        return -10;
                }
            }

            // check diagnal victory
            if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
            {
                if (b[0, 0] == 'O')
                    return +10;
                else if (b[0, 0] == 'X')
                    return -10;
            }

            if (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0])
            {
                if (b[0, 2] == 'O')
                    return +10;
                else if (b[0, 2] == 'X')
                    return -10;
            }

            // if nobody wins
            return 0;
        }
    }
}

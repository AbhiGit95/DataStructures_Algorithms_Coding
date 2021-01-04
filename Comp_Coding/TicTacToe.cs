using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class TicTacToe
    {
        /** Initialize your data structure here. */
        Dictionary<int, int> player1_rows;
        Dictionary<int, int> player1_cols;
        Dictionary<int, int> player1_diag;
        int p1_sdiag;
        Dictionary<int, int> player2_rows;
        Dictionary<int, int> player2_cols;
        Dictionary<int, int> player2_diag;
        int p2_sdiag;
        int limit;
        public TicTacToe(int n)
        {
            limit = n;
            player1_rows = new Dictionary<int, int>();
            player1_cols = new Dictionary<int, int>();
            player1_diag = new Dictionary<int, int>();
            p1_sdiag = 0;

            player2_rows = new Dictionary<int, int>();
            player2_cols = new Dictionary<int, int>();
            player2_diag = new Dictionary<int, int>();
            p2_sdiag = 0;
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            if (player == 1)
            {
                if (player1_rows.ContainsKey(row))
                {
                    player1_rows[row] += 1;
                }
                else
                {
                    player1_rows.Add(row, 1);
                }

                if (player1_cols.ContainsKey(col))
                {
                    player1_cols[col] += 1;
                }
                else
                {
                    player1_cols.Add(col, 1);
                }

                if (row == col)
                {
                    p1_sdiag += 1;
                }

                if (player1_diag.ContainsKey(row + col))
                {
                    player1_diag[row + col] += 1;
                }
                else
                {
                    player1_diag.Add(row + col, 1);
                }


                if (player1_rows[row] == limit || player1_cols[col] == limit || p1_sdiag == limit || (player1_diag.ContainsKey(row + col) && player1_diag[row + col] == limit))
                    return 1;
            }

            else
            {

                if (player2_rows.ContainsKey(row))
                {
                    player2_rows[row] += 1;
                }
                else
                {
                    player2_rows.Add(row, 1);
                }

                if (player2_cols.ContainsKey(col))
                {
                    player2_cols[col] += 1;
                }
                else
                {
                    player2_cols.Add(col, 1);
                }

                if (row == col)
                {
                    p2_sdiag += 1;
                }
                if (player2_diag.ContainsKey(row + col))
                {
                    player2_diag[row + col] += 1;
                }
                else
                {
                    player2_diag.Add(row + col, 1);
                }


                if (player2_rows[row] == limit || player2_cols[col] == limit || p2_sdiag == limit || (player2_diag.ContainsKey(row + col) && player2_diag[row + col] == limit))
                    return 2;
            }

            return 0;
        }
    }
}

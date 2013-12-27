using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1702
    {
        enum Piece { EMPTY,RED,BLUE};
        
        static Piece CheckWinner(Piece[,] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[0, i] != Piece.EMPTY)
                {
                    if (board[0, i] == board[1, i] &&
                        board[1, i] == board[2, i])
                        return board[0, i];
                }
                if (board[i, 0] != Piece.EMPTY)
                {
                    if (board[i, 0] == board[i, 1] &&
                       board[i, 1] == board[i, 2])
                        return board[i, 0];
                }
            }
            Piece leftDiag = board[0, 0];
            Piece rightDiag = board[0,board.Length - 1];
            if (leftDiag != Piece.EMPTY)
            {
                Boolean leftWin = true;
                for (int i = 1; i < board.Length; i++)
                {
                    if (board[i, i] != leftDiag)
                    {
                        leftWin = false;
                        break;
                    }
                }
                if (leftWin)
                    return leftDiag;
            }

            if (rightDiag != Piece.EMPTY)
            {
                Boolean rightWin = true;
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i, board.Length - i] != rightDiag)
                    {
                        rightWin = false;
                        break;
                    }
                }
                if (rightWin)
                    return rightDiag;
            }
            return Piece.EMPTY;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Solver_Sudoku
    {
        // ? va me permmettre d'autoriser de retourner un null
        public static (int row, int col)? empty_Case(char[][] board)
        {
            int m = board[0].Length;

            // parcours des lignees du tableau
            for (int i = 0; i < board.Length; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    if (board[i][j] == ' ')
                    {
                        // Je retourne la localisation de la case vite
                        return (i,j);
                    }
                    
                }
            }
            return null;
        }
        public void Resoudre_Sudoku(char[][] board)
        {
            var case_Vide = empty_Case(board);

            if (case_Vide == null)
                 Console.WriteLine("Votre sudoku est déjà résolu");

            int row = case_Vide.Value.row; 
            int col = case_Vide.Value.col;

            for (char chiffre = '1'; chiffre <= '9'; chiffre++)
            {
                board[row][col] = chiffre;

            }

        }
    }
}
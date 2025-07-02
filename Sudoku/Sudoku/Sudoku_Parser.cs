

namespace Sudoku
{
    internal class Sudoku_Parser
    {
        // Lire le fichier texte
        // Convertir les cacatères en un tableau de char 

        public static char[][] Parser(string path_File)
        {
            // Lire toutes les lignes du fichier
            string[] lines = File.ReadAllLines(path_File);
            // Déclaration du tableau qui va acceuillir le sudoku
            var board = new List<char[]>();
            // Pour chaque ligne du fichier, la convertir en char
            foreach (string line in lines)
            {
                // Prendre seulement les 9 premiers caractères si la ligne est trop longue
                string processedLine = line.Length >= 9 ? line.Substring(0, 9) : line.PadRight(9, '.');
                board.Add(processedLine.ToArray());
            }
            // boucler pour afficher le tableau sudoku
            foreach (char[] row in board)

            Console.WriteLine(new string(row)); 
            
            return board.ToArray() ;
          

        }
        // Rendre le sudoku plus lisible
        public static void print_Board(char[][] sudoku)
        {
            string horizontal_Separator = "+-------+-------+-------+";

            for (int row = 0; row < 9; row++)
            {
                // Chaque bloc de 3 lignes j'applique ma ligne pour séparer
                if (row%3 == 0)
                {
                    Console.WriteLine(horizontal_Separator);
                }
                 for (int column = 0; column < 9; column ++ )
                {
                    // Avant chaque bloc de 3 colonnes, afficher une barre verticale

                    if (column%3 == 0)
                    {
                        Console.Write("| ");
                    }
                    // je remplace le point par un espace pour plus de lisibilité
                    char replace_Point = sudoku[row][column] == '.' ? ' ' : sudoku[row][column];
                    Console.Write(replace_Point);
                    Console.Write(' ');
                }
                Console.WriteLine("|");


            }
            // Pour la bordure du bas j'applique ma ligne
            Console.WriteLine(horizontal_Separator);

        }

    }
}

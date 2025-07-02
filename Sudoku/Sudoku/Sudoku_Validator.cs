namespace Sudoku
{
    internal class Sudoku_Validator
    {
        // Vérification si : 
        // dimension 9*9
        // Pas de doublon dans les blocks de 3*3
        // Pas de doublon lignes du tableau
        // Pas de doublon colonnes du tableau
        public static bool is_Valid (char[][] board)
        {
            valid_Dimension(board);
            valid_Block(board);
            valid_Row(board);
            valid_Colums(board);
            Console.WriteLine("True");
            return true;
        }
        public static void valid_Dimension(char[][] board)
        {
            if (board.Length != 9)
            {
                throw new ArgumentException("Le tableau n'est pas de taille 9x9");
            }

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].Length != 9)
                {
                    throw new ArgumentException($"La ligne {i} a {board[i].Length} colonnes au lieu de 9");
                }
            }
        }
        public static void valid_Block(char[][] board)
        {
            // row_Block : démarre à 0, puis 3, puis 6 (coins supérieurs gauches des blocs)

            for (int row_Block = 0; row_Block < 9; row_Block += 3)
            {
               // colBlock : même principe pour les colonnes

                for (int col_Block = 0; col_Block < 9; col_Block += 3)
                {
                    // Un HashSet est créé pour chaque bloc 3×3 afin de détecter automatiquement les doublons.
                    var hashBlock = new HashSet<char>(); // collection qui détecte les doublons
                    //  i Parcour des lignes à l'intérieur d'un block
                    for (int i = row_Block; i < row_Block + 3; i++)
                    {
                        // j Parcours des colonnes à l'intérieur d'un block
                        for (int j = col_Block; j < col_Block + 3; j++)
                        {
                            char value = board[i][j];
                            if (value < '1' || value > '9')
                                continue;
                            if (!hashBlock.Add(value))
                                throw new ArgumentException("Il y a un doublon dans un bloc 3×3");
                        }
                    }
                }
            }
        }
        public static void valid_Row(char[][] board)
        {
            int m = board[0].Length;

            // parcours des lignees du tableau de 0 à 9
            for (int i = 0; i < board.Length; i++)
            {
                var hash = new HashSet<char>();

                // parcours les colonnes de la ligne courrante
                for (int j = 0; j < m; j++)
                {
                    char value = board[i][j];

                    if (value < '1' || value > '9')
                    {
                        continue;
                    }
                    if (!hash.Add(value))
                    {
                        throw new ArgumentException("Doublon détecté dans la ligne " + i);
                    }
                }
            }
        }
        public static void valid_Colums(char[][] board)
        {
            int m = board[0].Length;
            // i parcours les colonnes
            for (int i = 0; i < board.Length; i++)
            {

                var hash = new HashSet<char>();
                // j Parcours la ligne de la colonne courante
                for (int j = 0; j < m; j++)
                {
                    char value = board[i][j];

                    if (value < '1' || value > '9')
                    {
                        continue;
                    }
                    if (hash.Contains(value))
                    {
                        hash.Add(value);

                        throw new ArgumentException("Il y a un doubon dans une colonne ");

                    }
                }
            }
        }

    }
}



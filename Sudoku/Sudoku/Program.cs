using Sudoku;

char[][] sudoku = Sudoku_Parser.Parser(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data_File", "hard.data"));

Sudoku_Validator.is_Valid(sudoku);

Sudoku_Parser.print_Board(sudoku);
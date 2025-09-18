using Tetris.BoardGroup;

namespace Tetris.Duel
{
    internal class DuelBoardGrid(int rows, int columns) : BoardGrid (rows, columns)
    {
        public int garbageLines;

        private readonly Random rnd = new(); 
        
        public void AddGarbageLines(int lines)
        {
            garbageLines += lines;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (r - lines >= 0)
                    {
                        grid[r - lines, c] = grid[r, c];
                    }
                }
            }

            for (int r = rows - lines; r < rows; r++)
            {
                int bombColumn = rnd.Next(columns);
                for (int c = 0; c < columns; c++)
                {
                    grid[r, c] = -1;
                }
                grid[r, bombColumn] = -2;
            }
        }

        public bool IsCellBomb(int r, int c)
        {
            return IsInside(r, c) && grid[r, c] == -2;
        }

        public void ClearGarbageLines(int lines)
        {
            if (lines == 0 || garbageLines == 0) return;
            if (lines > garbageLines) lines = garbageLines;
            for (int r = rows - 1 - garbageLines; r >= 0; r--)
            {
                MoveRowDown(r, lines);
            }
            garbageLines -= lines;
        }
    }
}

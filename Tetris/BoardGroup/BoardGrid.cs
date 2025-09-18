namespace Tetris.BoardGroup
{
    internal class BoardGrid(int rows, int columns)
    {
        public int rows { get; } = rows;
        public int columns { get; } = columns;

        public int[,] grid = new int[rows, columns];

        protected bool IsInside(int r, int c) 
        {
            return r >= 0 && r < rows && c >= 0 && c < columns;
        }

        public bool IsCellEmpty(int r, int c)
        {
            return IsInside(r, c) && grid[r, c] == 0;
        }

        protected bool IsRowFull(int r)
        {
            for (int c = 0; c < columns; c++)
            {
                if (grid[r, c] <= 0) return false;
            }
            return true;
        }
        public bool IsRowEmpty(int r)
        {
            for (int c = 0; c < columns; c++)
            {
                if (grid[r, c] != 0) return false;
            }
            return true;
        }

        protected void ClearRow(int r)
        {
            for (int c = 0; c < columns; c++)
            {
                grid[r, c] = 0;
            }
        }

        protected void MoveRowDown(int r, int cleared)
        {
            for (int c = 0; c < columns; c++) {
                grid[r + cleared, c] = grid[r,c];
                grid[r, c] = 0;
            }
        }

        public int ClearFullRows()
        {
            int cleared = 0;
            for (int r =  rows - 1; r >= 0; r--)
            {
                if (IsRowFull(r)) { cleared++; ClearRow(r); }
                else if (cleared > 0) { MoveRowDown(r, cleared); }
            }
            return cleared;
        }
    }
}

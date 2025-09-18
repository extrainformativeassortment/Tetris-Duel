using Tetris.Blocks;

namespace Tetris.BoardGroup
{
    internal class BoardState
    {
        protected Block currentBlock;
        public Block CurrentBlock
        {
            get => currentBlock;
            protected set { currentBlock = value; currentBlock.Reset(); }
        }
        public Block HoldBlock { get; protected set; }
        protected bool canHold = true;

        public virtual BoardGrid BoardGrid { get; protected set; } = new(22, 10);
        public BlockQueue BlockQueue { get; } = new();

        public bool GameOver { get; protected set; }

        public int Score { get; protected set; }

        public BoardState()
        {
            CurrentBlock = BlockQueue.RandomBlock();
        }

        internal void Reset()
        {
            int rows = BoardGrid.rows;
            int columns = BoardGrid.columns;
        }

        protected bool BlockFits()
        {
            foreach (Position p in currentBlock.TilePositions())
            {
                if (!BoardGrid.IsCellEmpty(p.row, p.column))
                {
                    return false;
                }
            }
            return true;
        }

        public void RotateCW()
        {
            currentBlock.RotateCW();
            if (!BlockFits()) currentBlock.RotateCCW();
        }

        public void MoveHorizontal(int direction)
        {
            currentBlock.Move(0, direction);
            if (!BlockFits())
            {
                currentBlock.Move(0, -direction);
            }
        }

        protected bool IsGameOver() => !BoardGrid.IsRowEmpty(1);

        protected virtual void PlaceBlock()
        {
            foreach (Position p in currentBlock.TilePositions())
            {
                BoardGrid.grid[p.row, p.column] = currentBlock.Id;
            }

            Score += BoardGrid.ClearFullRows() * 10;

            if (IsGameOver())
            {
                GameOver = true;
            }
            else { CurrentBlock = BlockQueue.RandomBlock(); canHold = true; }
        }
        
        public void MoveDown()
        {
            currentBlock.Move(1, 0);
            if (!BlockFits()) 
            { 
                currentBlock.Move(-1, 0); 
                PlaceBlock(); 
            }
        }

        protected int TileDropDistance(Position p)
        {
            int drop = 0;

            while (BoardGrid.IsCellEmpty(p.row + drop + 1, p.column)) drop++;

            return drop;
        }

        public int BlockDropDistance()
        {
            int drop = BoardGrid.rows;

            foreach (Position p in currentBlock.TilePositions())
            {
                drop = Math.Min(drop, TileDropDistance(p));
            }

            return drop;
        }

        public void HardDrop()
        {
            CurrentBlock.Move(BlockDropDistance(), 0);
            PlaceBlock();
        }

        public void SwitchHold()
        {
            if (!canHold) return;

            canHold = false;

            if (HoldBlock is null)
            {
                HoldBlock = currentBlock;
                currentBlock = BlockQueue.RandomBlock();
                currentBlock.Reset();
                return;
            }

            (HoldBlock,currentBlock) = (currentBlock,HoldBlock);
            currentBlock.Reset();
        }
    }
}

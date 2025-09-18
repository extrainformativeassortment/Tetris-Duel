namespace Tetris.Blocks
{
    internal abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffset { get; }
        public abstract int Id { get; }

        private int rotationState;
        public Position offset;

        protected Block() { Reset(); }

        public IEnumerable<Position> TilePositions()
        {
            foreach (Position pos in Tiles[rotationState]) 
            { yield return new Position(pos.row + offset.row, pos.column + offset.column); }
        }
        public IEnumerable<Position> TilePositionsNoOffset()
        {
            foreach (Position pos in Tiles[rotationState])
            { yield return new Position(pos.row, pos.column); }
        }

        public void RotateCW() {  rotationState = (rotationState + 1) % 4; }
        public void RotateCCW() { rotationState = (rotationState + 3) % 4; }
        public void Move(int r, int c)
        {
            offset.row += r;
            offset.column += c;
        }
        public void Reset()
        {
            rotationState = 0;
            offset = StartOffset;
        }
    }
}

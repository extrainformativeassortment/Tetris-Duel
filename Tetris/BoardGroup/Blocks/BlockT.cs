namespace Tetris.Blocks
{
    internal class BlockT : Block
    {
        private readonly Position[][] tiles =
        [
            [new(0,1), new(1, 1), new(1, 2), new(2,1)],
            [new(1,0), new(1, 1), new(1, 2), new(2,1)],
            [new(0,1), new(1, 0), new(1, 1), new(2,1)],
            [new(0,1), new(1, 0), new(1, 1), new(1,2)]
        ];

        public override int Id => 6;
        protected override Position StartOffset => new(0, 3);
        protected override Position[][] Tiles => tiles;
    }
}

namespace Tetris.Blocks
{
    internal class BlockQueue
    {
        private readonly Block[] blocks =
            [
                new BlockI(),
                new BlockJ(),
                new BlockL(),
                new BlockO(),
                new BlockS(),
                new BlockT(),
                new BlockZ()
            ];

        private readonly Random rnd = new();

        public Block NextBlock { get; private set; } 

        public BlockQueue()
        {
            NextBlock = blocks[rnd.Next(blocks.Length)];
        }

        public Block RandomBlock()
        {
            Block block = NextBlock;
            NextBlock = blocks[rnd.Next(blocks.Length)];
            return block;
        }
    }
}

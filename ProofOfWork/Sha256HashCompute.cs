namespace ProofOfWork
{
    internal class Sha256HashCompute
    {
        private readonly string startingZeros;
        private readonly string path;
        private readonly Block block;

        public Sha256HashCompute(string startingZeros, string path, Block block)
        {
            this.startingZeros = startingZeros;
            this.path = path;
            this.block = block;
        }

        public void Compute()
        {
            while (!block.BlockHash.StartsWith(startingZeros))
            {
                block.PoWNonce++;
                block.BlockHash = HashCompute.ComputeSha256Hash(block.Data + block.PoWNonce.ToString());
            }
            FileManager.CreateBlockFile(path, block);
        }

        public bool CheckIfValid()
        {
            return HashCompute.ComputeSha256Hash(block.Data + block.PoWNonce.ToString()) == FileManager.GetBlockHashFromFile(path);
        }
    }
}

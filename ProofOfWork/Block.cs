namespace ProofOfWork
{
    public class Block
    {
        public string BlockHash { get; set; }
        public string Data { get; set; }
        public int PoWNonce { get; set; }
    }
}

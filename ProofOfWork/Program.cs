// See https://aka.ms/new-console-template for more information

using ProofOfWork;


string? startingZeros = "00000";
string path = $@"C:\Users\ovoroni\Desktop\pow\result-{Guid.NewGuid()}.json";
Block block = new()
{
    BlockHash = string.Empty,
    Data = Guid.NewGuid().ToString(),
    PoWNonce = 0
};

Sha256HashCompute sha256HashCompute = new Sha256HashCompute(startingZeros, path, block);

sha256HashCompute.Compute();

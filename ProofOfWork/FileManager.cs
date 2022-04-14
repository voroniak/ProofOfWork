using System.Text.Json;

namespace ProofOfWork
{
    internal class FileManager
    {

        public static void CreateBlockFile(string path, Block block)
        {
            using FileStream fileStream = File.Create(path);
            JsonSerializer.SerializeAsync(fileStream, block);
        }

        public static string GetBlockHashFromFile(string path)
        {
            Block block = JsonSerializer.Deserialize<Block>(File.ReadAllText(path));

            return block.BlockHash;
        }
    }
}

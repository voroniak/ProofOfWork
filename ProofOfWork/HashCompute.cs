using System.Security.Cryptography;
using System.Text;

namespace ProofOfWork
{
    internal class HashCompute
    {
        public static string ComputeSha256Hash(string data)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));

            StringBuilder builder = new();

            bytes.ToList().ForEach(b => builder.Append(b.ToString("x2")));

            return builder.ToString();
        }

    }
}

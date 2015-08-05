using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CriptografiaGPI
{
    public class Criptografia
    {
        private static readonly byte[] Complemento = Encoding.ASCII.GetBytes("o6806642kbM7c5");
        private const string Segredo = "GestaoPlanejamentoIndutrial";

        public static string Criptografar(string texto)
        {
            if(string.IsNullOrEmpty(texto))
                return String.Empty;

            string outStr;

            RijndaelManaged aesAlg = null;
            try
            {
                var key = new Rfc2898DeriveBytes(Segredo, Complemento);
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);
                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(texto);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                if (aesAlg != null)
                    aesAlg.Clear();
            }
            return outStr;
        }

        public static string Descriptografar(string codigo)
        {
            try
            {
                if (string.IsNullOrEmpty(codigo))
                    return String.Empty;
                string retorno;
                var chave = new Rfc2898DeriveBytes(Segredo, Complemento);

                var algoritimo = new RijndaelManaged();
                algoritimo.Key = chave.GetBytes(algoritimo.KeySize / 8);
                algoritimo.IV = chave.GetBytes(algoritimo.BlockSize / 8);

                var descriptografor = algoritimo.CreateDecryptor(algoritimo.Key, algoritimo.IV);
                var bytes = Convert.FromBase64String(codigo);

                using (var memoryStream = new MemoryStream(bytes))
                using (var cryptoStream = new CryptoStream(memoryStream, descriptografor, CryptoStreamMode.Read))
                using (var streamReader = new StreamReader(cryptoStream))
                    retorno = streamReader.ReadToEnd();

                algoritimo.Clear();

                return retorno;
            }
            catch (Exception)
            {
                return "DEU PAU";
            }
        }
    }
}

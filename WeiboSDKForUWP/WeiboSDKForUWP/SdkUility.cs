using System.Linq;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;

namespace WeiboSDKForUWP
{
    internal class SdkUility
    {
        /// <summary>
        /// Sha1加密
        /// </summary>
        /// <param name="baseString">需要加密的字符串</param>
        /// <param name="keyString">密钥</param>
        /// <returns></returns>
        internal static string Sha1Encrypt(string baseString, string keyString)
        {
            var crypt = MacAlgorithmProvider.OpenAlgorithm(MacAlgorithmNames.HmacSha1);
            var buffer = CryptographicBuffer.ConvertStringToBinary(baseString, BinaryStringEncoding.Utf8);
            var keyBuffer = CryptographicBuffer.ConvertStringToBinary(keyString, BinaryStringEncoding.Utf8);
            var key = crypt.CreateKey(keyBuffer);

            var sigBuffer = CryptographicEngine.Sign(key, buffer);
            var signature = CryptographicBuffer.EncodeToBase64String(sigBuffer);
            return signature;
        }

        internal static string GetQueryParameter(string input, string parameterName)
        {
            foreach (var parts in input.Split('&', '?').Select(item => item.Split('=')).Where(parts => parts[0] == parameterName))
            {
                return parts[1];
            }
            return string.Empty;
        }
    }
}
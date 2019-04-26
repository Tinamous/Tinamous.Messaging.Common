using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using AnalysisUK.Tinamous.Messaging.Common.Encryption;
using NUnit.Framework;

namespace AnalysisUK.Tinamous.Messaging.Common.Tests.Encryption
{
    [TestFixture]
    public class AESThenHMACEncryptionHelperTest
    {
        [Test]
        public void GenerateNewKeys()
        {
            // Arrange

            // Act
            byte[] newKey = AESThenHMACEncryptionHelper.NewKey();

            string key = Convert.ToBase64String(newKey);

            Trace.WriteLine(key);

            // Assert
            Assert.IsNotNull(key);
        }

        /// <summary>
        /// Helper to generate a bunch of keys to a file.
        /// These can then be randomly selected for use.
        /// </summary>
        [Test]
        [Explicit]
        public void GenerateALotOfNewKeys_WriteToFile()
        {
            // Arrange
            // Change the path as needed.
            using (FileStream file = File.OpenWrite(@"s:\RandomKeys.txt"))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    // Act
                    for (int i = 1; i < 2000; i++)
                    {
                        byte[] newKey = AESThenHMACEncryptionHelper.NewKey();

                        string key = Convert.ToBase64String(newKey);
                        writer.WriteLine(key);

                        Trace.WriteLine(key);

                        // Assert
                        Assert.IsNotNull(key);
                    }
                    file.Flush();
                }
            }
        }

        [Test]
        [TestCase("Password", "8oI/pQNdEx6aWNATrKVsUH0gU3wW3j05furiqLFax5k=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")]
        [TestCase("66021f5299d3566b142c930f0de78e573f711efede4634e9d24eb40a77289a7d", "8oI/pQNdEx6aWNATrKVsUH0gU3wW3j05furiqLFax5k=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")]
        [TestCase("Password", "8oI/pQNdEx6aWNATrKVsUH0gU3wW3j05furiqLFax5k=","bnIiLgHL13YWFTtxkicSMEHFF9tfAGJIZB29qNj3WNI=")] // Used below. ensure it's normally valid 
        [TestCase("Password","vU4tvO2eZPXJXxTJGoiGpZ1w/nuo59l55UvFchRNX5A=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Used below. ensure it's normally valid 
        [TestCase("Password","18cKBWuDPW5jVXn580mAxEAouNkRbMXq392WfQ/QFNk=","RbWZAwKpPx6zFLLuyubeR61i+QpLULw2kvHIGYrUYR4=")] // Used below. ensure it's normally valid 
        public void EncryptThenDecrypt_DecryptsSuccessfully(string toEncrypt, string encryptionKey, string authenticationKey)
        {
            // Arrange
            var encryptionKeyBytes = Convert.FromBase64String(encryptionKey);
            var authenticationKeyBytes = Convert.FromBase64String(authenticationKey);

            // Act
            string encrypted = AESThenHMACEncryptionHelper.SimpleEncrypt(toEncrypt, encryptionKeyBytes, authenticationKeyBytes);
            string decrypted = AESThenHMACEncryptionHelper.SimpleDecrypt(encrypted, encryptionKeyBytes, authenticationKeyBytes);

            // Assert
            Assert.AreEqual(toEncrypt, decrypted);
        }

        [Test]
        //[TestCase("8oI/pQNdEx6aWNATrKVsUH0gU3wW3j05furiqLFax5k=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Matching Keys, should fail
        [TestCase("8oI/pQNdEx6aWNATrKVsUH0gU3wW3j05furiqLFax5k=","bnIiLgHL13YWFTtxkicSMEHFF9tfAGJIZB29qNj3WNI=")] // Authentication key invalid
        [TestCase("18cKBWuDPW5jVXn580mAxEAouNkRbMXq392WfQ/QFNk=","RbWZAwKpPx6zFLLuyubeR61i+QpLULw2kvHIGYrUYR4=")] // Both keys invalid (Authentication should win)
        public void EncryptThenDecrypt_WhereAuthenticationKeyIsInvalid_DoesNotDecrypt(string encryptionKey, string authenticationKey)
        {
            // Arrange
            string toEncrypt = "Password";
            var encryptionKeyBytes = Convert.FromBase64String(encryptionKey);
            var authenticationKeyBytes = Convert.FromBase64String(authenticationKey);
            string encrypted = AESThenHMACEncryptionHelper.SimpleEncrypt(toEncrypt, encryptionKeyBytes, authenticationKeyBytes);

            var deencryptionKey = Convert.FromBase64String("8oI/pQNdEx6aWNATrKVsUH0gU3wW3j05furiqLFax5k=");
            var deauthentiationKey = Convert.FromBase64String("PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=");

            // Act
            string decrypted = AESThenHMACEncryptionHelper.SimpleDecrypt(encrypted, deencryptionKey, deauthentiationKey);

            // Assert
            Assert.AreNotEqual(toEncrypt, decrypted);
        }

        [Test]
        //[TestCase("8oI/pQNdEx6aWNATrKVsUH0gU3wW3j05furiqLFax5k=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Matching Keys, should fail
        [TestCase("18cKBWuDPW5jVXn580mAxEAouNkRbMXq392WfQ/QFNk=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Authentication key invalid
        [TestCase("NycT/TGBOY+mFcWrD+DCgQzCxvuj5j4Fq4FiCNcPSUk=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Authentication key invalid
        [TestCase("mzPu0mCsvNOL3nyGOqZPXo7Y3EftddJCbdstuO0k2ww=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Authentication key invalid
        [TestCase("/NHzPcYfQs9e2eFV7oGNdexpJx2b0SR1crYcMKte8Mg=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Authentication key invalid
        [TestCase("wPajG6F+krnbUAK1M2THLF6YVQF0QEdxdwDDKC/ekaQ=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Authentication key invalid
        [TestCase("MyBFejPSlYh2g8Ju9h5tiQQlEhpW+Q2irBDr15Siopc=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Authentication key invalid
        [TestCase("PmUtd9koxdSmhtJyy3pQqQEe8743cs7zDRDyGRt7i6k=","PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=")] // Authentication key invalid
        public void EncryptThenDecrypt_WhereEncryptionKeyIsInvalid_DoesNotDecrypt(string encryptionKey, string authenticationKey)
        {
            // Arrange
            string toEncrypt = "Password";
            var encryptionKeyBytes = Convert.FromBase64String(encryptionKey);
            var authenticationKeyBytes = Convert.FromBase64String(authenticationKey);
            string encrypted = AESThenHMACEncryptionHelper.SimpleEncrypt(toEncrypt, encryptionKeyBytes, authenticationKeyBytes);

            var deencryptionKey = Convert.FromBase64String("8oI/pQNdEx6aWNATrKVsUH0gU3wW3j05furiqLFax5k=");
            var deauthentiationKey = Convert.FromBase64String("PE6K9jw/KQMgHxpzUJpKuzlrIQxUZjzvCnVe2wMEheo=");

            // Act
            // Assert
            Assert.Throws<CryptographicException>(() => AESThenHMACEncryptionHelper.SimpleDecrypt(encrypted, deencryptionKey, deauthentiationKey));
        }
    }
}
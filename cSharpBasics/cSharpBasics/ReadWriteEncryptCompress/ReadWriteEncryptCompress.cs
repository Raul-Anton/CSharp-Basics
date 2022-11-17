using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics.ReadWriteEncryptCompress
{
    internal class ReadWriteEncryptCompress
    {
        public string path { get; set; }

        public ReadWriteEncryptCompress(string path)
        {
            this.path = path;
        }


        // write File
        public void WriteFile(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            using (FileStream fs = File.OpenWrite(path))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }


        // Enrypt & Decrypt File
        public void EncryptFile(string path)
        {
            try
            {
                AddEncryption(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DecryptFile(string path)
        {
            try
            {
                RemoveEncryption(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AddEncryption(string path)
        {
            try
            {
                File.Encrypt(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RemoveEncryption(string path)
        {
            try
            {
                File.Decrypt(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Compress & Decompress File

        
    }
}

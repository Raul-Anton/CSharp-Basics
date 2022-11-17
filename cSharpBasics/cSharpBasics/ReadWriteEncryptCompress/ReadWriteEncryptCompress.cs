using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Globalization;

namespace cSharpBasics.ReadWriteEncryptCompress
{
    internal class ReadWriteEncryptCompress
    {
        private string Path = @"E:\Amdaris\C#_Basics\CSharp-Basics\Customer.txt";

        private string OriginalFileName = "E:\\Amdaris\\C#_Basics\\CSharp-Basics\\Customer.txt";

        private string CompressedFileName = "E:\\Amdaris\\C#_Basics\\CSharp-Basics\\CompressedCustomer.gz";

        private string DecompressedFileName = "E:\\Amdaris\\C#_Basics\\CSharp-Basics\\DecompressedCustomer.txt";

        public ReadWriteEncryptCompress(string path, string originalFileName, string compressedFileName, string decompressedFileName)
        {
            Path= path;
            OriginalFileName= originalFileName;
            CompressedFileName= compressedFileName;
            DecompressedFileName= decompressedFileName;
        }

        // write File
        private void WriteFile(string s, string path)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            using (FileStream fs = File.OpenWrite(path))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        //read File
        private string ReadFile(string path)
        {
            string readFile = File.ReadAllText(path);

            return readFile;
        }


        // Enrypt & Decrypt File
        private void EncryptFile(string path)
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

        private void DecryptFile(string path)
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

        private void AddEncryption(string path)
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

        private void RemoveEncryption(string path)
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

        private void CompressFile(string originalFileName, string compressedFileName)
        {
            using FileStream originalFileStream = File.Open(originalFileName, FileMode.Open);
            using FileStream compressedFileStream = File.Create(compressedFileName);
            using var compressor = new GZipStream(compressedFileStream, CompressionMode.Compress);
            originalFileStream.CopyTo(compressor);
        }

        private void DecompressFile(string compressedFileName, string decompressedFileName)
        {
            using FileStream compressedFileStream = File.Open(compressedFileName, FileMode.Open);
            using FileStream outputFileStream = File.Create(decompressedFileName);
            using var decompressor = new GZipStream(compressedFileStream, CompressionMode.Decompress);
            decompressor.CopyTo(outputFileStream);
        }

        public void Write_Encrypt_Compress_File(string s)
        {
            WriteFile(s, Path);
            EncryptFile(Path);
            CompressFile(OriginalFileName, CompressedFileName);
        }

        public string Decompress_Decrypt_Read_File()
        {
            DecompressFile(CompressedFileName,DecompressedFileName);
            DecryptFile(DecompressedFileName);
            return ReadFile(DecompressedFileName);
        }
    }
}

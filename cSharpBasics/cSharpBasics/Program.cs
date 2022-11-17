using cSharpBasics;
using cSharpBasics.ReadWriteEncryptCompress;

Customer customer = new Customer(1, "Anton Raul", "raul.anton1999@gmail.com", "okeymage");

string path = @".\_Customer.txt";

string originalFileName = @".\_Customer.txt";

string compressedFileName = @".\_CompressedCustomer.gz";

string decompressedFileName = @".\_DecompressedCustomer.txt";

ReadWriteEncryptCompress rwec = new ReadWriteEncryptCompress(path, originalFileName, compressedFileName, decompressedFileName);

rwec.Write_Encrypt_Compress_File(customer.ToString());

Console.WriteLine(rwec.Decompress_Decrypt_Read_File());
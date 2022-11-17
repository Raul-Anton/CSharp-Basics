using cSharpBasics;
using cSharpBasics.ReadWriteEncryptCompress;

Customer customer = new Customer(1, "Anton Raul", "raul.anton1999@gmail.com", "okeymage");

//string path = @"E:\Amdaris\C#_Basics\CSharp-Basics\Customer.txt";

//string originalFileName = "E:\\Amdaris\\C#_Basics\\CSharp-Basics\\Customer.txt";

//string compressedFileName = "E:\\Amdaris\\C#_Basics\\CSharp-Basics\\CompressedCustomer.gz";

//string decompressedFileName = "E:\\Amdaris\\C#_Basics\\CSharp-Basics\\DecompressedCustomer.txt";


string path = @"C:\Users\vladv\Desktop\CSharp-Basics\Customer.txt";

string originalFileName = @"C:\Users\vladv\\Desktop\CSharp-Basics\Customer.txt";

string compressedFileName = @"C:\Users\vladv\Desktop\CSharp-Basics\CompressedCustomer.gz";

string decompressedFileName = @"C:\Users\vladv\Desktop\CSharp-Basics\DecompressedCustomer.txt";



ReadWriteEncryptCompress rwec = new ReadWriteEncryptCompress(path, originalFileName, compressedFileName, decompressedFileName);

rwec.Write_Encrypt_Compress_File(customer.ToString());

Console.WriteLine(rwec.Decompress_Decrypt_Read_File());
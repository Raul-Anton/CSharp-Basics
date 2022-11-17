using cSharpBasics;
using cSharpBasics.ReadWriteEncryptCompress;

Customer customer = new Customer(1, "Anton Raul", "raul.anton1999@gmail.com", "okeymage");

string path = @"E:\Amdaris\C#_Basics\CSharp-Basics\Customer.txt";

ReadWriteEncryptCompress rwec = new ReadWriteEncryptCompress(path);

rwec.WriteFile(customer.ToString());

rwec.AddEncryption(path);

//rwec.RemoveEncryption(path);


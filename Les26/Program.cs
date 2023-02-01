using System.IO;
using System.Text;

#region File
//var lines = new string[]
//{
//    "tom", "bob", "mark"
//};
//File.WriteAllLines("file.txt", lines);
//var readLines = File.ReadAllLines("file.txt");
//Console.WriteLine(string.Join("\n", readLines));
#endregion

#region FileStream
//FileStream
//var file  = new FileStream("fileStream.txt", FileMode.OpenOrCreate);
//file.Close();

//using (var file = new FileStream("file.txt", FileMode.OpenOrCreate))
//{
//    Console.WriteLine(file.Length);
//    Console.WriteLine(file.Position);
//    Console.WriteLine(file.Name);

//    file.Seek(3, SeekOrigin.Begin);
//    Console.WriteLine(file.Position);

//    file.Seek(2, SeekOrigin.Current);
//    Console.WriteLine(file.Position);

//}
//Flush 
#endregion

#region FileStream-Write-Read

string fileName = $"{nameof(fileName)}.txt";
string text = "hello filestream!!!";

using (var file = new FileStream(fileName, FileMode.OpenOrCreate))
{
    var bytes = Encoding.Default.GetBytes(text);

    file.Write(bytes, 0, bytes.Length);
    file.WriteByte(63);
    //file.Flush();
    Console.WriteLine("Text wrote");

}

using (var file = File.OpenRead(fileName))
{
    file.Seek(6, SeekOrigin.Begin);
    byte[] bytes = new byte[10];
    file.Read(bytes, 0, bytes.Length);
    string readText = Encoding.Default.GetString(bytes);
    //Console.WriteLine(string.Join(" ", bytes));
    Console.WriteLine(readText);
}

#endregion
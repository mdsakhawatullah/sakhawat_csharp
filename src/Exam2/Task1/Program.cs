using System;
using System.IO;
using System.Text;

long sizeGB = 5;
long sizeBytes = sizeGB * 1024 * 1024 * 1024;

string filePath = "../../../../demo.txt";
long fileInBytes = TextGeneratorFile(filePath, sizeBytes);

Console.WriteLine(sizeBytes);
if (fileInBytes == sizeBytes) Console.WriteLine("done");


static long TextGeneratorFile(string filePath, long sizeBytes)

{
    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
    {
        Random random = new Random(DateTime.Now.Millisecond);
        long fileInBytes = 0;
        while (fileInBytes < sizeBytes)
        {
            char randomChar = GetRandomChar(random);
            writer.Write(randomChar);
            fileInBytes += sizeof(char);
        }
        return fileInBytes;
    }
}


/*for (int i = 0; i < 10; i++)
    Console.WriteLine(GetRandomChar(random));*/

static char GetRandomChar(Random random)
{
    return (char)random.Next('A', 'Z');
}
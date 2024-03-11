using System;
using System.Diagnostics;
using System.IO;
using System.Text;

string filePath = "../../../../demo.txt";
int sizeMB = 100;
long sizeInBytes = sizeMB * 1024 * 1024;

string folderPath = $"Folder1";
Directory.CreateDirectory(folderPath);

using (FileStream fileStream = File.OpenRead(filePath))
{
    byte[] bytes = new byte[sizeMB];
    int bytesRead = 0;
    long totalRead = 0;

}
Console.WriteLine("done");
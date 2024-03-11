using System;
using System.Diagnostics;
using System.IO;
using System.Text;

string filePath = "../../../../demo.txt";
int sizeMB = 100;
long sizeInBytes = sizeMB * 1024 * 1024;

int folderCount = 1;
string folderPath = $"Folder{folderCount}";
Directory.CreateDirectory(folderPath);

using (FileStream fileStream = File.OpenRead(filePath))
{
    byte[] bytes = new byte[sizeMB];
    int bytesRead = 0;
    long totalRead = 0;

    while ((bytesRead = fileStream.Read(bytes, 0, bytes.Length)) > 0)
    {
        string sizeMBFilePath = Path.Combine(folderPath, $"smallTextFile{folderCount}.txt");
        using (FileStream sizeMBFileStream = File.Create(sizeMBFilePath))
        {
            sizeMBFileStream.Write(bytes, 0, bytesRead);
        }

        totalRead += bytesRead;


        if (totalRead > sizeInBytes)
        {
            folderCount++;
            folderPath = $"Folder{folderCount}";
        }

    }

}
Console.WriteLine("done");
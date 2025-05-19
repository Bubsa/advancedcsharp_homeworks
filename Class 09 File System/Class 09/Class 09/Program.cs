using Qinshift.Helpers;
using System.Globalization;
using System.IO;

// ABSOLUTNI PATISHTA

string studentsRepoFoldersFullPath = @"C:\Users\code\Documents\GitHub\advancedcsharp_homeworks\Class 09 File System\Class 09";
string timeTrackingHomeworkFullPath = @"C:\Users\code\Documents\GitHub\advancedcsharp_homeworks\Class 09 File System\File System";

// RELATIVNI PATISHTA

string classReadmeRelativePath = @"..\..\..\..\..\ README.md";

Console.WriteLine("========== DIRECTORY (Folder) ===============");

// Zemi ja segashnata pateka na folderot

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory {currentDirectory}");

// Proveri dali postoi folder
#region
string testFolderPath = @"..\..\..\TestFolder";
bool testFolderExists = Directory.Exists(testFolderPath);

Console.WriteLine("The folder 'TestFolder' exists {0}", testFolderExists);

if (!testFolderExists)
{
    Directory.CreateDirectory(testFolderPath);
    Console.WriteLine("TestFolder created successfully");
}
else
{
    Console.WriteLine("TestFolder already exists");
}
#endregion

// Brishenje na folder
#region
//if (Directory.Exists(testFolderPath))
//{
//    Directory.Delete(path: testFolderPath);
//}
#endregion

Console.WriteLine("=================== FILE =====================");


// PRAVENJE NA FAJL
#region
testFolderPath = @"..\..\..\TestFolder";
string fileName = "example.txt";
// string filePath = $@"{testFolderPath}\{fileName}";
// Istoto ko ova gore ama na drug nacin
string filePath = Path.Combine(testFolderPath, fileName);

bool fileExists = File.Exists(filePath);

if (!fileExists)
{
    File.Create(filePath).Close(); // Za da se izvrshi kodot na linija 80, mora da se pishe .Close() metodata za da moze da se izvrshi kodot pravilno
}
else
{
    Console.WriteLine("File already exists");
}
#endregion

// BRISHENJE NA FAJL
#region
//if (File.Exists(filePath))
//{
//    File.Delete(filePath);
//}
#endregion

// PISHUVANJE VO FAJL
#region
File.WriteAllText(filePath, "Hello From G3!");
File.WriteAllText(filePath, "Hello from Qinshift"); // So ovaa linija na kod, tekstot se prepishuva i samo se stava ovoj text a ne dvata.
#endregion


// CHITANJE OD FAJL
#region
string fileContent = File.ReadAllText(filePath);
Console.WriteLine(fileContent);
#endregion

// ZEMANJE INFO OD FAJL
#region
// INFORMACIJA IDE OVDE
FileInfo fileInfo = new FileInfo(filePath);
ConsoleHelper.WriteInColor("\nThe File's Info: ", ConsoleColor.Blue);
Console.WriteLine("Full Name: " + fileInfo.FullName);
Console.WriteLine("File Name: " + fileInfo.Name);
Console.WriteLine("Extension: " + fileInfo.Extension);
Console.WriteLine("Size: " + fileInfo.Length + " bytes");
Console.WriteLine("Created On: " + fileInfo.CreationTime);
Console.WriteLine("Last Modified: " + fileInfo.LastWriteTime);
#endregion



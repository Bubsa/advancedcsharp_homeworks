using Qinshift.Helpers;

ConsoleHelper.WriteInColor("\n================== FILE STREAMS ==================\n", ConsoleColor.Blue);

// SETUP
#region

string folderPath = @"..\..\..\TestFiles";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

string fileName = "notes.txt";
string fileFullPath = Path.Combine(folderPath, fileName);
#endregion

ConsoleHelper.WriteInColor("\n================== STREAM WRITER ==================\n", ConsoleColor.Cyan);

#region
using (StreamWriter streamWriter = new StreamWriter(fileFullPath)) // Using ti ovozmozuva da bide napraveno da ti go zavrshi kodot isto kako vo 62ra linija na prethodniot Program.cs
 {
    streamWriter.WriteLine("This is a simple note");
    streamWriter.WriteLine("StreamWriter lets us write text line by line efficiently");
    streamWriter.WriteLine("It also allows you to append or overwrite");
 }

//using (StreamWriter streamWriter = new StreamWriter(fileFullPath)) // Kolku pati i da pishuvas vaka sekogas ke se prepishuva toa sho go ima ovde 
//{
//    streamWriter.WriteLine("This is another note.");
//    streamWriter.WriteLine("StreamWriter is awesome");

//}

using (StreamWriter streamWriter = new StreamWriter(fileFullPath, append: true)) // Se dodeka ne stavish append, tek togas si se dodava na tekstot kolku pati da ja uklucis aplikacijata
{
    streamWriter.WriteLine("This is another note.");
    streamWriter.WriteLine("StreamWriter is awesome");
}
#endregion

ConsoleHelper.WriteInColor("\n================== STREAM READER ==================\n", ConsoleColor.Cyan);

#region

try
{
    using (StreamReader streamReader = new StreamReader(fileFullPath))
    {
        ConsoleHelper.WriteInColor("Reading file content using StreamReader: \n", ConsoleColor.Yellow);

        // Linija po linija kako da gi ischitash

        //string firstLine = streamReader.ReadLine();
        //Console.WriteLine("First line: " + firstLine);

        //string secondLine = streamReader.ReadLine();
        //Console.WriteLine("Second line: " + secondLine);

        //string thirdLine = streamReader.ReadLine();
        //Console.WriteLine("Third line: " + thirdLine);



        // Istiot task ko pogore ama po dinamichki nachin

        string line = streamReader.ReadLine();
        while ( line != null)
        {
            Console.WriteLine(line);
            line = streamReader.ReadLine();
        }
    }
}
catch (Exception ex)
{
    ConsoleHelper.WriteInColor("Error reading file:" + ex.Message, ConsoleColor.Red);
}

#endregion
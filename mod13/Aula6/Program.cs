using System.Collections;

internal class Program {
    private static void Main(string[] args) {
        string path = @"c:\temp\myfolder\file1.txt";
        DirectoryInfo di = new DirectoryInfo(path);


        Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
        Console.WriteLine("PathSeparator: " + Path.PathSeparator);
        Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
        Console.WriteLine("GetFileName: " + Path.GetFileName(path));
        Console.WriteLine("GetExtension: " + Path.GetExtension(path));
        Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
        Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        try {
            

        }
        catch (IOException e) {
            Console.WriteLine("An error occurred: ");
            Console.WriteLine(e.Message);
        }
        catch (Exception e) {
            Console.WriteLine("An error occurred: ");
            Console.WriteLine(e.Message);
        }
    }
}
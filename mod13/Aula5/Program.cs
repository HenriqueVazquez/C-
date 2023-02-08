using System.Collections;

internal class Program {
    private static void Main(string[] args) {
        string path = @"c:\temp\myfolder";
       DirectoryInfo di = new DirectoryInfo(path);

        try {
            // IEnumerable<string> folders =   Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories
            var folders = di.EnumerateDirectories("*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS");
            foreach(var s in folders) {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            var files = di.EnumerateFiles("*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES");
            foreach (var s in files) {
                Console.WriteLine(s);
            }

            //Criar uma pasta

            //Directory.CreateDirectory(path + @"\newfolder");
            di.CreateSubdirectory("newfolder");

        }
        catch (IOException e) {
            Console.WriteLine("An error occurred: ");
            Console.WriteLine(e.Message);
        }catch(Exception e) {
            Console.WriteLine("An error occurred: ");
            Console.WriteLine(e.Message);
        }
    }
}
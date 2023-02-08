internal class Program {
    private static void Main(string[] args) {
        string sourcePath = @"c:\temp\file1.txt";
        string targetPath = @"c:\temp\file2.txt";

        try {
            FileInfo fileInfo = new(sourcePath);

            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines) {
                Console.WriteLine(line);
            }

        }catch(IOException e) {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
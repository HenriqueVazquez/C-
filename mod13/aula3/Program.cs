internal class Program {
    private static void Main(string[] args) {
        string path = @"c:\temp\file1.txt";
        try {
            //using (FileStream fs = new FileStream(path, FileMode.Open)) {
            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                //  }    
            }
        }
        catch (IOException e) {
            Console.WriteLine("An error occurred!");
            Console.WriteLine(e.Message);
        }
    }
}
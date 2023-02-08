internal class Program {
    private static void Main(string[] args) {
        string path = @"c:\temp\file1.txt";
      //  FileStream fs = null;
        StreamReader sr = null;
        try {
           // fs = new FileStream(path, FileMode.Open);
            sr = File.OpenText(path);
            while (!sr.EndOfStream) {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException e) {
            Console.WriteLine("An error eccurred");
            Console.WriteLine(e.Message);
        }
        finally { 
            if(sr != null) sr.Close();
           // if (fs != null) fs.Close();
        }
    }
}
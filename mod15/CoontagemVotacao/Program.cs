using System;
using System.Collections.Generic;
using System.IO;
class Program {
    static void Main(string[] args) {

        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();

        try {
            using (StreamReader sr = File.OpenText(path)) {

                Dictionary<string, int> ballotBox = new ();

                while (!sr.EndOfStream) {

                    string[] votingRecord = sr.ReadLine().Split(',');
                    string candidate = votingRecord[0];
                    int votes = int.Parse(votingRecord[1]);

                    if (ballotBox.ContainsKey(candidate)) {
                        ballotBox[candidate] += votes;
                    }
                    else {
                        ballotBox[candidate] = votes;
                    }
                }

                foreach (var item in ballotBox) {
                
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
        }
        catch (IOException e) {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }

    }
}

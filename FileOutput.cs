using System.IO;
using System;

public class FileOutput{
    StreamWriter sw = null;
    private string FileName;

    public FileOutput (string FileName){
        this.FileName = FileName;
        if (!File.Exists(FileName)){
        File.Create(FileName).Dispose();
        sw = new StreamWriter(FileName, false);
        }
    }

        public void fileWrite(string line) {
            using( var stream = File.Open(FileName, FileMode.Open)){
                try {
                    sw.Write(line + "\n");
                } catch (Exception e) {
                    Console.WriteLine("File Write Error: " + FileName + " " + e);
                }
            }
            
    }

    // public void FileClose() {
    //     using( var stream = File.Open(FileName, FileMode.Open)){
    //         if (sw != null) {
    //             try {
    //                 sw.Close();
    //             } catch (IOException e) {
    //                 e.ToString();
    //             }
    //         }
    //     }
    // }
}
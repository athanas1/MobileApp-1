using System;
using System.IO;
public class FileInput{
    private string FileName;
    private StreamReader sr = null;

    public FileInput (string FileName){
        this.FileName = FileName;
        using( var stream = File.Open(FileName, FileMode.Open)){
        try{
            sr = new StreamReader(FileName);
        } catch(FileNotFoundException e)
        {
            System.Console.WriteLine("File Open Error:" + FileName + " " + e);
        }
        }
    }

    public void FileRead(){
        string line;
        using( var stream = File.Open(FileName, FileMode.Open)){
        try{
            while((line = sr.ReadLine()) != null){
                System.Console.WriteLine(line);
            }
        } catch(Exception e){
            System.Console.WriteLine("File Write Error: " + FileName + " " + e);
        }
        }
    }

        public String fileReadLine() {
         using( var stream = File.Open(FileName, FileMode.Open)){
        try {
            String line = sr.ReadLine();
            return line;
        } catch (Exception e) {
            Console.WriteLine("File Write Error: " + FileName + " " + e);
            return null;
        }
        }
    }

        public void fileClose() {
        using( var stream = File.Open(FileName, FileMode.Open)){
        if (sr != null) {
            try {
                sr.Close();
            } catch (IOException e) {
                e.ToString();
            }
        }
        }

    }


}
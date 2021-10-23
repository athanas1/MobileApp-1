using System.IO;
using System;

public class FileOutput{
    StreamWriter sw = null;
    private string FileName;

    public FileOutput (string FileName){
        this.FileName = FileName;
        using( var stream = File.Open(FileName, FileMode.Open)){
            try{
                sw = new StreamWriter(FileName);
            } catch(FileNotFoundException e)
            {
                System.Console.WriteLine("File Open Error:" + FileName + " " + e);
            } catch(Exception e){
            System.Console.WriteLine("oops" + e);
            }
            
        }
    }

        public void fileWrite(string line) {
        try
        {
            sw.Write(line + "\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("File Write Error: " + FileName + " " + e);
        }
    }



    public void FileClose() {
        
            if (sw != null) {
                try {
                    sw.Close();
                } catch (IOException e) {
                    e.ToString();
                }
            }
        }
    
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace MobileApp_1
{
    class Program
    {
            private static FileOutput OutFile = new FileOutput("../MobileApp-1/animals.txt");
            private static FileInput InFile = new FileInput("../MobileApp-1/animals.txt");
        static void Main(string[] args)
        {
            List<Talkable> Zoo = new List<Talkable>();

            Zoo.Add(new Dog(true, "Bean"));
            Zoo.Add(new Cat(9,"Charlie"));
            Zoo.Add(new Teacher(44,"Stacy Read"));

            foreach(var a in Zoo){
                printOut(a);
            }
            OutFile.FileClose();
            InFile.FileRead();
            InFile.fileClose();

            FileInput InData = new FileInput("../MobileApp-1/animals.txt");
            string Line;
            while((Line = InData.fileReadLine()) != null){
                System.Console.WriteLine(Line);
            }
        }
        public static void printOut(Talkable p) {
        Console.WriteLine(p.GetName() + " says=" + p.Talk());
        OutFile.fileWrite(p.GetName() + " | " + p.Talk());
        
    }
    }
}

public class Teacher : Person, Talkable{
private int Age{get;set;}

public Teacher(int Age, string Name) : base(Name){
    this.Age = Age;
    this.Name = Name;
}


public string Talk(){
    return "Don't forget to do the assigned reading!";
}

}
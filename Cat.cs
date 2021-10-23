public class Cat : Pet, Talkable{
    private int MousesKilled;

    public Cat(int MousesKilled, string Name) : base(Name){
        this.Name = Name;
        this.MousesKilled = MousesKilled;
    }
    public string Talk(){
        return "Meow";
    }
    public override string ToString(){
        return "Cat: " + "Name=" + Name + " MousesKilled=" + MousesKilled;
    }
}
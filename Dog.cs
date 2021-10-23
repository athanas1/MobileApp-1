public class Dog : Pet, Talkable{
    private bool Friendly;

    public Dog(bool Friendly, string Name) : base(Name){
        this.Name = Name;
        this.Friendly = Friendly;
    }
    public bool IsFriendly(){
        return Friendly;
    }

    public string Talk(){
        return "Bark";
    }
    public override string ToString(){
        return "Dog: " + "name=" + Name + " friendly=" + Friendly;
    }
}
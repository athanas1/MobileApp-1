public abstract class Pet{
    protected string Name{get;set;}

    public Pet(string Name){
        this.Name=Name;
    }
    public string GetName(){
    return Name;
}
}
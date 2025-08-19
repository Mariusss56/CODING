public class FamilyMember{
    private String Name;
    private int Age;
    public FamilyMember next;

    public FamilyMember(){
        this.Name="";
        this.Age=0;
        this.next=null;

    }
    public FamilyMember(String Name, int Age){
        this.Name=Name;
        this.Age=Age;
        this.next=next;
    }
    public void setName (String Name, FamilyMember next){
        this.Name=Name;
    }
     public String getName(){
        return Name;
    }
      public void setAge (int Age, FamilyMember next){
        this.Age=Age;
    }
     public int getAge(){
        return Age;
    }
}
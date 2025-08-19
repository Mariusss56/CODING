public class FamilyMemberHistory {
    public static void main(String[] args) {
        
        FamilyMember FM1= new FamilyMember("Marius ",20);
        FamilyMember FM2= new FamilyMember("Mary Rose ",26);
        FamilyMember FM3= new FamilyMember("Marichu ",56);

        FM1.next=FM2;
        FM2.next=FM3;

        FamilyMember current=FM1;
        while (current !=null) {
           System.out.println("FAMILY MEMBERS: "+current.getName()+""+current.getAge());
        current=current.next;
        
        }
    }
}

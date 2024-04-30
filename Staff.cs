namespace FinalProjectIronHaven;

public class Staff
{
    private static int autoincrement;
    public int ID {get;}
    public string username {get; set;}
    public string password {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}

    public Staff
    {
        autoincrement++ ;
        ID = autoincrement; 
    }

}

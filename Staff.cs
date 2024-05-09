namespace FinalProjectIronHaven;

public class Staff : Member
{
    private static int autoincrement;
    public int StaffID { get; set; }
    public string Role { get; set; }
    public DateTime HireDate { get; set; }

    public Staff()
    {
        autoincrement++;
        StaffID = autoincrement;
    }

}

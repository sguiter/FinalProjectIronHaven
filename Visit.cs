namespace FinalProjectIronHaven;

public class Visit
{
    private static int autoIncrement;
    public int Id {get;}
    public DateTime dateTime {get; set;}

    public Visit()
    {
        autoIncrement++;
        Id = autoIncrement;
    }
}
                                                                                                                                                                                                                                                                                                  
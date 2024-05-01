namespace FinalProjectIronHaven;

public class MembershipPlan
{
    public string PlanName { get; set; }
    public double Price { get; set; }
    public int features { get; set; }

    public MembershipPlan(string planName, double price, int features)
    {
        PlanName = planName;
        Price = price;
        this.features = features;
    }

}

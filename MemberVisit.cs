namespace FinalProjectIronHaven;

public class MemberVisit
{
    public Member m {get; set;}
    public Visit v {get; set;}

    public MemberVisit(Member m, Visit v)
    {
        this.m = m;
        this.v = v;
    }
}
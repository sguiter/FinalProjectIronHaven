using System.Linq.Expressions;

namespace FinalProjectIronHaven;

public class Members
{
    public List<Member> memberList { get; set; }

    public Members()
    {
        memberList = new List<Member>();
    }

    public Member Authenticate(string username, string password)
    {
        var m = memberList.Where(o => (o.Username == username) && (o.Password == password));

        if (m.Count() > 0)
        {
            return m.First();
        }
        else
        {
            return null;
        }
    }

}

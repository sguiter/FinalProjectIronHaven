using System.ComponentModel.Design;
using System.Net.Security;
using System.Security.Cryptography;

namespace FinalProjectIronHaven;

class Program

{
    private static Members members;
    private static List<Visit> visits;
    private static List<MemberVisit> memberVisits;
     private static List<MembershipPlan> plans;
     private static List<Staff> staff; 
     private static List<Member> member; 
     private static Member authenticatedMember;

     static void Main(string[] args)
     {
        Console.WriteLine("Welcome to Iron Haven Gym");
        Initialize();
        Menu();
        //MemberMenu();
            
     }

    static void Initialize()
    {
        var c1 = new Member
        {
            FirstName = "John",
            LastName = "Doe",
            Username = "johndoe",
            Password = "12345",
        };

        var c2 = new Member
        {
            FirstName = "Jane",
            LastName = "Doe",
            Username = "janedoe",
            Password = "5678",
        };

        var s1 = new Staff
        {
            FirstName = "Ben",
            LastName = "Alban",
            Username = "benalban",
            Password = "pass",
            Role = "Trainer",
            HireDate = DateTime.Now
        };

        var s2 = new Staff
        {
            FirstName = "Chris",
            LastName = "Magnus",
            Username = "chrismags",
            Password = "word",
            Role = "Manager",
            HireDate = DateTime.Now
        };

        var v1 = new Visit();
        var v2 = new Visit();
        var v3 = new Visit();

        var mv1 = new MemberVisit(c1, v1);
        var mv2 = new MemberVisit(c1, v2);
        var mv3 = new MemberVisit(c2, v3);

        members = new Members();
        members.memberList.Add(c1);
        members.memberList.Add(c2);

        memberVisits = new List<MemberVisit>();
        memberVisits.Add(mv1);
        memberVisits.Add(mv2);
        memberVisits.Add(mv3);

        visits = new List<Visit>();
        visits.Add(v1);
        visits.Add(v2);
        visits.Add(v3);

        staff = new List<Staff>();
        staff.Add(s1);
        staff.Add(s2);

        var p1 = new MembershipPlan("Basic", 20, 1);
        var p2 = new MembershipPlan("Standard", 30, 2);
        var p3 = new MembershipPlan("Premium", 40, 3);

        plans = new List<MembershipPlan>();
        plans.Add(p1);
        plans.Add(p2);
        plans.Add(p3);


    }
        
    static void Menu()
    {
        bool done = false;

        while (!done)
        {
            System.Console.WriteLine("Options: Login: 1, Register: 2, VisitsMenu: 3, Logout 4:, View Plans 5:, Exit: q");
            System.Console.Write("Enter Option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    LoginMenu();
                    break;
                case "2":
                    RegisterMenu();
                    break;
                case "3":
                    VisitsMenu();
                    break;
                case "4":
                    LogOutMenu();
                    break;
                case "5":
                    DisplayPlans();
                    break;
                case "q":
                    done = true;
                    break;
                default:
                    System.Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }

    static void LoginMenu()
    {
        if(authenticatedMember == null)
        {
            System.Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            System.Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            authenticatedMember = members.Authenticate(username, password);

            if (authenticatedMember != null)
            {
                System.Console.WriteLine($"Welcome {authenticatedMember.FirstName}");
            }
            else
            {
                System.Console.WriteLine("Invalid Username or Password");
            }
        }
    }

    static void RegisterMenu()
    {
        System.Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        System.Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        System.Console.Write("Enter Username: ");
        string username = Console.ReadLine();
        System.Console.Write("Enter Password: ");
        string password = Console.ReadLine();
        System.Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        var member = new Member
        {
            FirstName = firstName,
            LastName = lastName,
            Username = username,
            Password = password,
        };

        members.memberList.Add(member);
        System.Console.WriteLine("Member Registered");
    }
        static void VisitsMenu()
    {
        if (authenticatedMember == null)
        {
            Console.WriteLine("Please log in first!");
            return;
        }

        var visitList = memberVisits.Where(o => o.m.Username == authenticatedMember.Username);

        if(visitList.Count() == 0)
        {
            Console.WriteLine("No Visits Found");
            return;
        }
        else
        {
            foreach(var visit in visitList)
            {
                Console.WriteLine(visit.v.dateTime);
            }
        }
    }

    static void LogOutMenu()
    {
        authenticatedMember = null;
        Console.WriteLine("You have been logged out!");
    }

    static void DisplayPlans()
    {
        foreach(var plan in plans)
        {
            Console.WriteLine($"{plan.PlanName} - {plan.Price} - {plan.features}");
        }
    }

    /* static void MemberMenu()
    {
        bool done = false;

        while (!done)
        {
            System.Console.WriteLine("Options: View Profile: 1, View Plans: 2, Logout: 3");
            System.Console.Write("Enter Option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    DisplayMember();
                    break;
                case "2":
                    DisplayPlans();
                    break;
                case "3":
                    Console.WriteLine("You have been logged out");
                    done = true;
                    break;
                default:
                    System.Console.WriteLine("Invalid Option");
                    break;
            }
       
        }
    }

    static void DisplayMember()
    {
        Console.WriteLine(authenticatedMember);
    }

    static void DisplayPlans()
    {
        foreach(var plan in plans)
        {
            Console.WriteLine(plan);
        }
    }

    static void StaffMenu()
    {
        bool done = false;

        while (!done)
        {
            System.Console.WriteLine("Options: View Profile: 1, View Members: 2, View Visits: 3, Logout: 4");
            System.Console.Write("Enter Option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    System.Console.WriteLine(authenticatedMember);
                    break;
                case "2":
                    System.Console.WriteLine(member);
                    break;
                case "3":
                    System.Console.WriteLine(visits);
                    break;
                case "4":
                    Console.WriteLine("You have been logged out");
                    done = true;
                    break;
                default:
                    System.Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
    */
}
    


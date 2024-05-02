﻿using System.ComponentModel.Design;
using System.Net.Security;

namespace FinalProjectIronHaven;

class Program

{
    private static Members members;
    private static List<Visit> visits;
     private static List<MembershipPlan> plans;
     private static List<Staff> staff; 
     private static Member authenticatedMember;

     static void Main(string[] args)
     {
        Console.WriteLine("Welcome to Iron Haven Gym");
        Initialize();
        Menu();
        MemberMenu();
            
     }

    static void Initialize()
    {
        var c1 = new Member
        {
            FirstName = "John",
            LastName = "Doe",
            Username = "johndoe",
            Password = "1234",
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
            Username = "johndoe",
            Password = "word",
            Role = "Trainer",
            HireDate = DateTime.Now
        };

        var s2 = new Staff
        {
            FirstName = "Chris",
            LastName = "MAgnus",
            Username = "janedoe",
            Password = "want",
            Role = "Manager",
            HireDate = DateTime.Now
        };

        var v1 = new Visit();
        var v2 = new Visit();
        var v3 = new Visit();

        var p1 = new MembershipPlan("Basic", 20, 1);
        var p2 = new MembershipPlan("Standard", 30, 2);
        var p3 = new MembershipPlan("Premium", 40, 3);

        members = new Members();

    }
        
    static void Menu()
    {
        bool done = false;

        while (!done)
        {
            System.Console.WriteLine("Options: Login: 1, Register: 2, Exit: 3");
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
                MemberMenu();
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

    static void MemberMenu()
    {
        bool done = false;

        while (!done)
        {
            System.Console.WriteLine("Options: View Profile: 1, View Plans: 2, View Visits: 3 Logout: 4");
            System.Console.Write("Enter Option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    System.Console.WriteLine(authenticatedMember);
                    break;
                case "2":
                    System.Console.WriteLine(plans);
                    break;
                case "3":
                    System.Console.WriteLine(visits);
                    break;
                case "4":
                    done = true;
                    break;
                default:
                    System.Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
    
}
    


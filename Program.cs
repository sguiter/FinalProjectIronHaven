using System.ComponentModel.Design;

namespace FinalProjectIronHaven;

class Program
{
    {
        private static Member member;
        private static List<Visit> visits;
        private static List<MembershipPlan> plans;
        private static List<Staff> staff; 
        private static Member aunthenticatedMember;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Iron Haven Gym");
            Initialize();
            Menu();
            
        }

        static void initialize()
        {
            var c1 = new Member
            {
                FirstName = "John",
                LastName = "Doe",
                Username = "johndoe",
                Password = "password",
            };

            var c2 = new Member
            {
                FirstName = "Jane",
                LastName = "Doe",
                Username = "janedoe",
                Password = "password",
            };

            var s1 = new Staff
            {
                FirstName = "Ben",
                LastName = "Alban",
                Username = "johndoe",
                Password = "password",
                Role = "Trainer",
                HireDate = DateTime.Now
            };

            var s2 = new Staff
            {
                FirstName = "Chris",
                LastName = "MAgnus",
                Username = "janedoe",
                Password = "password",
                Role = "Manager",
                HireDate = DateTime.Now
            };

            var v1 = new Visit();
            var v2 = new Visit();
            var v3 = new Visit();

            var p1 = new MembershipPlan("Basic", 20, 1);
            var p2 = new MembershipPlan("Standard", 30, 2);
            var p3 = new MembershipPlan("Premium", 40, 3);

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

    }


}

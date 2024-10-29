using System;
using System.Collections.Generic;

namespace _233536_LAB_MID_PAPER_VISUAL_PROGRAMMING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student_club studentClub = new Student_club();
            Society society = new Society();
            FUNDED_SOCITY fundedSociety = new FUNDED_SOCITY();
            Nonfunded_socity nonfundedSociety = new Nonfunded_socity();

            studentClub.president = "Rana Faizan";
            studentClub.vice_president = "ABDULMOUEED";
            studentClub.general_secetary = "RAYYAN";
            studentClub.finance_secretary = "AYESHA";
            studentClub.budget = 1000;

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Register Society");
                Console.WriteLine("2. Display Societies");
                Console.WriteLine("3. Add Fund");
                Console.WriteLine("4. Show Fund Info");
                Console.WriteLine("5. Add Member to Society");
                Console.WriteLine("6. Show Members");
                Console.WriteLine("7. Register Activity");
                Console.WriteLine("8. Register Event");
                Console.WriteLine("9. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        studentClub.register_society();
                        break;
                    case "2":
                        studentClub.display_society();
                        break;
                    case "3":
                        fundedSociety.add_fund();
                        break;
                    case "4":
                        fundedSociety.show_info();
                        break;
                    case "5":
                        society.add_member();
                        break;
                    case "6":
                        society.show_members();
                        break;
                    case "7":
                        society.add_activityies();
                        break;
                    case "8":
                        society.add_event();
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }

    class Student_club
    {
        public string president { get; set; }
        public string vice_president { get; set; }
        public string general_secetary { get; set; }
        public string finance_secretary { get; set; }

        private List<string> society_name = new List<string>();
        private List<string> society_description = new List<string>();
        private List<string> team_leader_name = new List<string>();
        private List<string> Assisstant_team_leader_name = new List<string>();
        public double budget { get; set; }
        public List<double> budgt = new List<double>();

        public void register_society()
        {
            Console.WriteLine("Enter name of the society: ");
            string society_names = Console.ReadLine();
            society_name.Add(society_names);

            Console.WriteLine("Enter description of the society: ");
            string society_descriptions = Console.ReadLine();
            society_description.Add(society_descriptions);

            Console.WriteLine("Enter name of the Team Leader: ");
            string team_leader_names = Console.ReadLine();
            team_leader_name.Add(team_leader_names);

            Console.WriteLine("Enter name of the Assistant Team Leader: ");
            string Assisstant_team_leader_names = Console.ReadLine();
            Assisstant_team_leader_name.Add(Assisstant_team_leader_names);

            Console.WriteLine("Assign budget to society: ");
            double bd;
            while (true)
            {
                Console.Write("Enter the budget: ");
                bd = Convert.ToDouble(Console.ReadLine());
                if (bd < 0 || bd > budget)
                {
                    Console.WriteLine("Wrong input, type again: ");
                }
                else
                {
                    budget -= bd;
                    budgt.Add(bd);
                    break;
                }
            }
        }

        public void display_society()
        {
            if (society_name.Count == 0)
            {
                Console.WriteLine("No societies registered.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Societies are:");
            for (int i = 0; i < society_name.Count; i++)
            {
                Console.WriteLine($"NAME OF THE SOCIETY: {society_name[i]}");
                Console.WriteLine($"DESCRIPTION OF SOCIETY: {society_description[i]}");
                Console.WriteLine($"TEAM LEADER OF SOCIETY: {team_leader_name[i]}");
                Console.WriteLine($"ASSISTANT OF SOCIETY: {Assisstant_team_leader_name[i]}");
                Console.WriteLine($"BUDGET OF SOCIETY: {budgt[i]}");
            }
        }
    }

    class Society : Student_club
    {
        private List<string> society_member = new List<string>();
        private List<string> contact = new List<string>();
        private List<string> activity = new List<string>();
        private List<string> events = new List<string>();

        public void add_member()
        {
            Console.WriteLine("Enter name of the society member: ");
            string name = Console.ReadLine();
            society_member.Add(name);

            Console.WriteLine("Enter contact no of the society member: ");
            string number = Console.ReadLine();
            contact.Add(number);
        }

        public void add_activityies()
        {
            Console.WriteLine("Enter activity name: ");
            string activ = Console.ReadLine();
            activity.Add(activ);
            Console.WriteLine($"Activity '{activ}' added to the society.");
        }

        public void add_event()
        {
            Console.WriteLine("Enter event name: ");
            string event_name = Console.ReadLine();
            events.Add(event_name);
            Console.WriteLine($"Event '{event_name}' added to the society.");
        }

        public void show_members()
        {
            if (society_member.Count == 0)
            {
                Console.WriteLine("No members in the society.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("The members are:");
            for (int i = 0; i < society_member.Count; i++)
            {
                Console.WriteLine($"Name: {society_member[i]}, Contact: {contact[i]}");
            }
        }

        public void show_activities()
        {
            if (activity.Count == 0)
            {
                Console.WriteLine("No activities registered.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("The activities are:");
            foreach (string item in activity)
            {
                Console.WriteLine(item);
            }
        }

        public void show_events()
        {
            if (events.Count == 0)
            {
                Console.WriteLine("No events registered.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("The events are:");
            foreach (string item in events)
            {
                Console.WriteLine(item);
            }
        }
    }

    class FUNDED_SOCITY : Society
    {
        private List<double> funding_amt = new List<double>();
        private List<string> name = new List<string>();
        private List<string> contact = new List<string>();

        public void add_fund()
        {
            Console.WriteLine("Enter your name: ");
            string names = Console.ReadLine();
            name.Add(names);

            double amounts;
            while (true)
            {
                Console.WriteLine("Enter your amount: ");
                amounts = Convert.ToDouble(Console.ReadLine());
                if (amounts <= 0)
                {
                    Console.WriteLine("Wrong input, type again.");
                }
                else
                {
                    budget += amounts;
                    funding_amt.Add(amounts);
                    break;
                }
            }

            Console.WriteLine("Enter your contact: ");
            string contacts = Console.ReadLine();
            contact.Add(contacts);
        }

        public void show_info()
        {
            if (name.Count == 0)
            {
                Console.WriteLine("No funding information available.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Funds info are:");
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine($"Name: {name[i]}");
                Console.WriteLine($"Contact info: {contact[i]}");
                Console.WriteLine($"Funding amount: {funding_amt[i]}");
            }
        }
    }

    class Nonfunded_socity : FUNDED_SOCITY
    {
        public List<string> name_nonfunded_society = new List<string>();

        public void add_non()
        {
            Console.WriteLine("Enter name of non-funded society: ");
            string n = Console.ReadLine();
            name_nonfunded_society.Add(n);
        }

        public void show()
        {
            if (name_nonfunded_society.Count == 0)
            {
                Console.WriteLine("No non-funded societies registered.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Non-funded societies are:");
            foreach (string item in name_nonfunded_society)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;

namespace Task3
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }
        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            //Username = new string(username);
            Username = username;
            Password = password;
            Messages = new string[messages.Length];
            Array.Copy(messages, Messages, messages.Length);
        }
        public User() {
            Id = new Random().Next(999);
            Username = "";
            Password = "";
            Messages = new string[]{ };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User[] users =
            {
                new User(),
                new User(1, "johndoe", "doej0hn", new string[]{"buy bread", "buy juice"}),
                new User(6, "bob", "bobsky", new string[]{"message1", "message2", "message3"})
            };
            users[0].Username = "darijan";
            users[0].Password = "pa$$w0rd";
            users[0].Messages = new string[] { "reboot pc", "push to github", "update windows" };

            string choice;
            while(true) {
                Console.WriteLine("(L)og in, (R)egister?");
                choice = Console.ReadLine().ToLower();
                if (!string.IsNullOrWhiteSpace(choice) && "lr".Contains(choice)) break;
                else Console.WriteLine("Please enter a valid option!");
            }

            if (choice == "l") Login(users);
            else Register(users);
        }

        private static void Register(User[] users)
        {
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            if(Array.Exists(users, x => x.Username == username && x.Password == password ))
            {
                Console.WriteLine("User already exists!");
            } else
            {
                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = new User(id, username, password, new string[] { });

                Console.WriteLine("Registered successfully!\n");
                string header = string.Format("{0,3} | {1, -15}", "Id", "Username");
                Console.WriteLine(header);
                Console.WriteLine(new string('-', header.Length));
                Array.ForEach(users, u => Console.WriteLine("{0:000} | {1}", u.Id, u.Username));
            }
        }

        private static void Login(User[] users)
        {
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            foreach(User u in users)
            {
                if(u.Username == username && u.Password == password)
                {
                    Console.WriteLine("Welcome {0}. Here are your messages:", username);
                    foreach(string m in u.Messages) Console.WriteLine(m);
                    return;
                }
            }

            Console.WriteLine("No such user found!");
        }
    }
}

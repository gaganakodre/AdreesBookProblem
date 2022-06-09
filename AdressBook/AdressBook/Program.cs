namespace AdressBook
{
    class program
    {
        

        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to AdressBook");
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        
                        AdressBook1.AddPerson();
                        break;
                }
            }

                }
    }
}

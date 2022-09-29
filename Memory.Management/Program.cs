namespace Memory.Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            string s = "Hello World";

            User user = new()
            {
                Id = 234,
                Name = "Jon Doe"
            };

            Console.WriteLine("{0}. Username: {1}", user.Id, user.Name);
            Console.WriteLine("Echo Number: " + user.EchoNumber(i));

            Console.WriteLine("Number Value: " + i);
            Console.WriteLine("String Value: " + s);
            Console.ReadLine();
        }

        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public int EchoNumber(int value)
            {
                value++;
                return value;
            }

            public string EchoString(string value)
            {
                value = "ECHO: " + value;
                return value;
            }

            public override string ToString()
            {
                return this.Name;
            }
        }
    }
}
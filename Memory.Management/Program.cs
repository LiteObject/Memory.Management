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

            Console.ReadLine();
        }

        struct User
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return this.Name;
            }
        }
    }
}
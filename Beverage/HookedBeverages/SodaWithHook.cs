namespace TemplateMethodPattern
{
    internal class SodaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Opening bottle of soda");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding ice and a slice of lemon");
        }

        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like ice and a slice of lemon with your soda (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}

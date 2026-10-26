namespace TemplateMethodPattern
{
    public class ChocolateMilk : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Using choclate powder in boiled water");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipcream");
        }
    }
}

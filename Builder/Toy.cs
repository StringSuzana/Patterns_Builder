namespace Builder
{
    public class Toy : ISurprise
    {
        public string Name { get; set; }
        public string GetName()
        {
            return Name;
        }
    }
}

namespace Builder
{
    public class GiftCard : ISurprise
    {
        public string Name { get; set; }
        public string GetName()
        {
            return Name;
        }
    }
}

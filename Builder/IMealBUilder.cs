namespace Builder
{
    public interface IMealBUilder
    {
        void Reset();

        void AddName(string name);
        void AddMeat();
        void AddBun();
        Meal Bake();
        void AddToy();
        void AddGiftCard();
    }
}

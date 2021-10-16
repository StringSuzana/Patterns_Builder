namespace Builder
{
    public class Director
    {
        private IMealBUilder _builder;
        public IMealBUilder Builder
        {
            set { _builder = value; }
        }
        public Meal MakeKidsMeal(string name)
        {
            _builder.Reset();
            _builder.AddName(name);
            _builder.AddBun();
            _builder.AddMeat();
            _builder.AddToy();

            return _builder.Bake();
 
        }
        public Meal MakeAdultsMeal(string name)
        {
            _builder.Reset();
            _builder.AddName(name);
            _builder.AddBun();
            _builder.AddMeat();
            _builder.AddMeat();
            _builder.AddGiftCard();

            return _builder.Bake();
        }

    }
}

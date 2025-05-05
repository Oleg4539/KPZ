namespace task5
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetHeight(int height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetHairColor(string color)
        {
            _character.HairColor = color;
            return this;
        }

        public ICharacterBuilder AddClothes(string clothes)
        {
            _character.Clothes.Add(clothes);
            return this;
        }

        public ICharacterBuilder AddInventory(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public ICharacterBuilder DoGood()
        {
            _character.Deeds.Add("Saved the village");
            _character.Deeds.Add("Helped the poor");
            return this;
        }

        public ICharacterBuilder DoEvil()
        {
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}

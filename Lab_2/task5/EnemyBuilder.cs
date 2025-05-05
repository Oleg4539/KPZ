namespace task5
{
    public class EnemyBuilder : ICharacterBuilder
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
            return this;
        }

        public ICharacterBuilder DoEvil()
        {
            _character.Deeds.Add("Burned the village");
            _character.Deeds.Add("Stole treasure");
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}

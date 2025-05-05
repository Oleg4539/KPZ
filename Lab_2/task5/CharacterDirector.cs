namespace task5
{
    public class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder
                .SetHeight(180)
                .SetHairColor("Brown")
                .AddClothes("Cape")
                .AddInventory("Sword")
                .DoGood()
                .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder
                .SetHeight(190)
                .SetHairColor("Black")
                .AddClothes("Armor")
                .AddInventory("Axe")
                .DoEvil()
                .Build();
        }
    }
}

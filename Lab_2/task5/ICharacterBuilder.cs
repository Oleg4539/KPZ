namespace task5
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(int height);
        ICharacterBuilder SetHairColor(string color);
        ICharacterBuilder AddClothes(string clothes);
        ICharacterBuilder AddInventory(string item);
        ICharacterBuilder DoGood();
        ICharacterBuilder DoEvil();
        Character Build();
    }
}

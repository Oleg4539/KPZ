public class Warrior : IHero
{
    public string GetDescription() => "Воїн";
    public int GetPower() => 10;
}

public class Mage : IHero
{
    public string GetDescription() => "Маг";
    public int GetPower() => 8;
}

public class Palladin : IHero
{
    public string GetDescription() => "Паладин";
    public int GetPower() => 9;
}
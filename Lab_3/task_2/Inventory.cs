public class Sword : HeroDecorator
{
    public Sword(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + " зі мечем";
    public override int GetPower() => _hero.GetPower() + 5;
}

public class Armor : HeroDecorator
{
    public Armor(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + " в броні";
    public override int GetPower() => _hero.GetPower() + 3;
}

public class Artifact : HeroDecorator
{
    public Artifact(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + " з артефактом";
    public override int GetPower() => _hero.GetPower() + 7;
}
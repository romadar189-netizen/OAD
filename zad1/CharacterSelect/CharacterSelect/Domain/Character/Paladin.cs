using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Paladin : Entity.Character
{
    public Paladin(string name) : base(name, CharacterClass.Paladin)
    {
        Health = 150;
        Strength = 6;
        Intelligence = 16;
        Agility = 10;
        Luck  = 5;
        Charisma = 10;
    }
}
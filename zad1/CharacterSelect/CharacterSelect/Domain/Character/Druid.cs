using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Druid : Entity.Character
{
    public Druid(string name) : base(name, CharacterClass.Druid)
    {
        Health = 95;
        Strength = 5;
        Intelligence = 10;
        Agility = 10;
        Luck = 5;
        Charisma = 4;
    }
}
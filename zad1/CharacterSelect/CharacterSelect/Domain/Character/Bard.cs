using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Bard : Entity.Character
{
    public Bard(string name) : base(name, CharacterClass.Bard)
    {
        Health = 70;
        Strength = 4;
        Intelligence = 16;
        Agility = 18;
        Luck  = 5;
        Charisma = 20;
    }
}
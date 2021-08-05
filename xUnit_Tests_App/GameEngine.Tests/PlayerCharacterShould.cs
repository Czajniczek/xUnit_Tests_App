using System;
using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        // Postaæ gracza powinna nie mieæ doœwiadczenia, gdy jest tworzona
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();
        }
    }
}

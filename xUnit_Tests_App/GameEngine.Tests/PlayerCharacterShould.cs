using System;
using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        // Posta� gracza powinna nie mie� do�wiadczenia, gdy jest tworzona
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();
        }
    }
}

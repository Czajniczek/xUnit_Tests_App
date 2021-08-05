using System;
using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        #region Adding an Assert to the First Test
        // Postaæ gracza powinna nie mieæ doœwiadczenia, gdy jest tworzona
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }
        #endregion

        #region Making Assertions Against String Values
        [Fact]
        public void CalculateFullName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.Equal("Sarah Smith", sut.FullName);
        }

        [Fact]
        public void HaveFullNameStartingWithFirstName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.StartsWith("Sarah", sut.FullName);
        }

        [Fact]
        public void HaveFullNameEndingWithLastName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            //sut.FirstName = "XXX";
            sut.LastName = "Smith";

            Assert.EndsWith("Smith", sut.FullName);
        }

        [Fact]
        public void CalculateFullName_IgnoreCaseAssertExample()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "SARAH";
            sut.LastName = "SMITH";

            Assert.Equal("Sarah Smith", sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullName_SubstringAssertExample()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.Contains("ah Sm", sut.FullName);
        }

        [Fact]
        public void CalculateFullNameWithTitleCase()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            // Pierwsza du¿a litera imienia i pierwsza du¿a litera nazwiska
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);
        }
        #endregion
    }
}

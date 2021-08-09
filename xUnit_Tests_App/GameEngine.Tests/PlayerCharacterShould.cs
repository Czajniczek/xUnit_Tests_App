using System;
using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould : IDisposable
    {
        private readonly PlayerCharacter _sut;
        private readonly ITestOutputHelper _output;

        public PlayerCharacterShould(ITestOutputHelper output)
        {
            _sut = new PlayerCharacter();
            _output = output;
            _output.WriteLine("Creating new PlayerCharacter");
        }

        // Wewn¹trz tej metody mo¿emy wykonaæ dowolny kod czyszczenia
        public void Dispose()
        {
            _output.WriteLine($"Disposing PlayerCharacter {_sut.FullName}");

            //_sut.Dispose();
        }

        #region Adding an Assert to the First Test
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //Assert.True(sut.IsNoob);
            ////Assert.False(sut.IsNoob);


            Assert.True(_sut.IsNoob);
            //Assert.False(_sut.IsNoob);
        }
        #endregion

        #region Making Assertions Against String Values
        [Fact]
        public void CalculateFullName()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //sut.FirstName = "Sarah";
            //sut.LastName = "Smith";

            //Assert.Equal("Sarah Smith", sut.FullName);
            ////Assert.NotEqual("Sarah Smith", sut.FullName);


            _sut.FirstName = "Sarah";
            _sut.LastName = "Smith";

            Assert.Equal("Sarah Smith", _sut.FullName);
            //Assert.NotEqual("Sarah Smith", _sut.FullName);
        }

        [Fact]
        public void HaveEmptytNickname()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //sut.Nickname = "";

            //Assert.Empty(sut.Nickname);


            _sut.Nickname = "";

            Assert.Empty(_sut.Nickname);
        }

        [Fact]
        public void HaveFullNameStartingWithFirstName()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //sut.FirstName = "Sarah";
            //sut.LastName = "Smith";

            //Assert.StartsWith("Sarah", sut.FullName);


            _sut.FirstName = "Sarah";
            _sut.LastName = "Smith";

            Assert.StartsWith("Sarah", _sut.FullName);
        }

        [Fact]
        public void HaveFullNameEndingWithLastName()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            ////sut.FirstName = "XXX";
            //sut.LastName = "Smith";

            //Assert.EndsWith("Smith", sut.FullName);


            //_sut.FirstName = "XXX";
            _sut.LastName = "Smith";

            Assert.EndsWith("Smith", _sut.FullName);
        }

        [Fact]
        public void CalculateFullName_IgnoreCaseAssertExample()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //sut.FirstName = "SARAH";
            //sut.LastName = "SMITH";

            //Assert.Equal("Sarah Smith", sut.FullName, ignoreCase: true);


            _sut.FirstName = "SARAH";
            _sut.LastName = "SMITH";

            Assert.Equal("Sarah Smith", _sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullName_SubstringAssertExample()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //sut.FirstName = "Sarah";
            //sut.LastName = "Smith";

            //Assert.Contains("ah Sm", sut.FullName);


            _sut.FirstName = "Sarah";
            _sut.LastName = "Smith";

            Assert.Contains("ah Sm", _sut.FullName);
        }

        [Fact]
        public void CalculateFullNameWithTitleCase()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //sut.FirstName = "Sarah";
            //sut.LastName = "Smith";

            //// Pierwsza du¿a litera imienia i pierwsza du¿a litera nazwiska (wyra¿enie regularne)
            //Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);


            _sut.FirstName = "Sarah";
            _sut.LastName = "Smith";

            // Pierwsza du¿a litera imienia i pierwsza du¿a litera nazwiska (wyra¿enie regularne)
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", _sut.FullName);
        }
        #endregion

        #region Asserting on Numeric Values
        [Fact]
        public void StartWithDefaultHealth()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //Assert.Equal(100, sut.Health);


            Assert.Equal(100, _sut.Health);
        }

        [Fact]
        public void StartWithDefaultHealth_NotEqualExample()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //Assert.NotEqual(0, sut.Health);


            Assert.NotEqual(0, _sut.Health);
        }

        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //sut.Sleep(); // Expect increase between 1 to 100 inclusive

            ////Assert.True(sut.Health >= 101 && sut.Health <= 200);
            //Assert.InRange(sut.Health, 101, 200); // Lepsze, poniewa¿ zwraca wiêcej informacji a nie same True/False


            _sut.Sleep(); // Expect increase between 1 to 100 inclusive

            //Assert.True(_sut.Health >= 101 && sut.Health <= 200);
            Assert.InRange(_sut.Health, 101, 200); // Lepsze, poniewa¿ zwraca wiêcej informacji a nie same True/False
        }
        #endregion

        #region Asserting Null Values
        [Fact]
        public void NotHaveNickNameByDefault()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //Assert.Null(sut.Nickname);
            ////Assert.NotNull(sut.Nickname);


            Assert.Null(_sut.Nickname);
            //Assert.NotNull(_sut.Nickname);
        }
        #endregion

        #region Asserting with Collections
        [Fact]
        public void HaveALongBow()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //Assert.Contains("Long Bow", sut.Weapons);


            Assert.Contains("Long Bow", _sut.Weapons);
        }

        [Fact]
        public void NotHaveAStaffOfWonder()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //Assert.DoesNotContain("Staff Of Wonder", sut.Weapons);


            Assert.DoesNotContain("Staff Of Wonder", _sut.Weapons);
        }

        [Fact]
        public void HaveAtLeastOneKindOfSword()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //// Sprawdzenie, czy lista broni ma przynajmniej jeden rodzaj miecza
            //Assert.Contains(sut.Weapons, weapon => weapon.Contains("Sword"));


            // Sprawdzenie, czy lista broni ma przynajmniej jeden rodzaj miecza
            Assert.Contains(_sut.Weapons, weapon => weapon.Contains("Sword"));
        }

        [Fact]
        public void HaveAllExpectedWeapons()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //var expectedWeapons = new[]
            //{
            //    "Long Bow",
            //    "Short Bow",
            //    "Short Sword"
            //};

            //Assert.Equal(expectedWeapons, sut.Weapons);


            var expectedWeapons = new[]
            {
                "Long Bow",
                "Short Bow",
                "Short Sword"
            };

            Assert.Equal(expectedWeapons, _sut.Weapons);
        }

        [Fact]
        public void HaveNoEmptyDefaultWeapons()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //Assert.All(sut.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));


            Assert.All(_sut.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));
        }
        #endregion

        #region Asserting That Events Are Raised
        [Fact]
        public void RaiseSleptEvent()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //Assert.Raises<EventArgs>(
            //    handler => sut.PlayerSlept += handler,
            //    handler => sut.PlayerSlept -= handler,
            //    () => sut.Sleep());

            Assert.Raises<EventArgs>(
                handler => _sut.PlayerSlept += handler,
                handler => _sut.PlayerSlept -= handler,
                () => _sut.Sleep());
        }

        [Fact]
        public void RaisePropertyChangedEvent()
        {
            //PlayerCharacter sut = new PlayerCharacter();

            //// Klasa (PlayerCharacter) musi dziedziczyæ po "INotifyPropertyChanged"
            //Assert.PropertyChanged(sut, "Health", () => sut.TakeDamage(10));

            // Klasa (PlayerCharacter) musi dziedziczyæ po "INotifyPropertyChanged"
            Assert.PropertyChanged(_sut, "Health", () => _sut.TakeDamage(10));
        }
        #endregion

        #region Adding Extra PlayerCharacter Tests
        //[Fact]
        //public void TakeZeroDamage()
        //{
        //    _sut.TakeDamage(0);

        //    Assert.Equal(100, _sut.Health);
        //}

        //[Fact]
        //public void TakeSmallDamage()
        //{
        //    _sut.TakeDamage(1);

        //    Assert.Equal(99, _sut.Health);
        //}

        //[Fact]
        //public void TakeMediumDamage()
        //{
        //    _sut.TakeDamage(50);

        //    Assert.Equal(50, _sut.Health);
        //}

        //[Fact]
        //public void HaveMinimum1Health()
        //{
        //    _sut.TakeDamage(101);

        //    Assert.Equal(1, _sut.Health);
        //}
        #endregion

        #region Refactoring to Data-driven Tests
        [Theory]
        [InlineData(0, 100)]
        [InlineData(1, 99)]
        [InlineData(50, 50)]
        [InlineData(101, 1)]
        public void TakeDamage(int damage, int expectedHealth)
        {
            _sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, _sut.Health);
        }
        #endregion
    }
}

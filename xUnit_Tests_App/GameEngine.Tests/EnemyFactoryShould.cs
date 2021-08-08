using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GameEngine.Tests
{
    [Trait("Category", "Enemy")]
    public class EnemyFactoryShould
    {
        #region Making Asserts Against Object Types
        [Fact]
        //[Trait("Category", "Enemy")]
        public void CreateNormalEnemyByDefault()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie");

            Assert.IsType<NormalEnemy>(enemy);
        }

        [Fact(Skip = "Don't need to run this")]
        public void CreateNormalEnemyByDefault_NotTypeExample()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie");

            Assert.IsNotType<DateTime>(enemy);
        }

        [Fact]
        public void CreateBossEnemy()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie King", true);

            Assert.IsType<BossEnemy>(enemy);
        }

        [Fact]
        public void CreateBossEnemy_CastReturnedTypeExample()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie King", true);

            // Assert and get cast result
            // Gdy używamy metody "IsType", jeśli Assert się powiedzie, możemy odzyskać obiekt określonego typu
            BossEnemy boss = Assert.IsType<BossEnemy>(enemy);

            // Additional asserts on typed object
            Assert.Equal("Zombie King", boss.Name);
        }

        [Fact]
        public void CreateBossEnemy_AssertAssignableTypes()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy = sut.Create("Zombie King", true);

            //Assert.IsType<Enemy>(enemy); //Nie uwzględnia dziedziczenia (restrykcyjnie) - nie powiedzie się, ponieważ jest <BossEnemy> a nie <Enemy>
            //Assert.IsType<BossEnemy>(enemy);
            Assert.IsAssignableFrom<Enemy>(enemy); //Uwzględnia dziedziczenie
        }
        #endregion

        #region Asserting on Object Instances
        [Fact]
        public void CreateSeparateInstances()
        {
            EnemyFactory sut = new EnemyFactory();

            Enemy enemy1 = sut.Create("Zombie");
            Enemy enemy2 = sut.Create("Zombie");

            // Sprawdzenie czy dwa obiekty nie są tym samym wystąpieniem (czy nie jest to ten sam wróg)
            Assert.NotSame(enemy1, enemy2);

            //Enemy enemy1 = sut.Create("Zombie");
            //Enemy enemy2 = enemy1;

            //// Sprawdzenie czy dwa obiekty są tym samym wystąpieniem (czy jest to ten sam wróg)
            //Assert.Same(enemy1, enemy2);
        }
        #endregion

        #region Asserting That Code Throws the Correct Exceptions
        [Fact]
        public void NotAllowNullName()
        {
            EnemyFactory sut = new EnemyFactory();

            //Assert.Throws<ArgumentNullException>(() => sut.Create(null));

            // Nazwa parametru, którym spodziewamy się wywołać wyjątek
            Assert.Throws<ArgumentNullException>("name", () => sut.Create(null));

            // Nie powiedzie się, ponieważ "name" wywołuje wyjątek a nie "isBool"
            //Assert.Throws<ArgumentNullException>("isBoss", () => sut.Create(null));
        }

        [Fact]
        public void OnlyAllowKingOrQueenBossEnemies()
        {
            EnemyFactory sut = new EnemyFactory();

            EnemyCreationException ex = Assert.Throws<EnemyCreationException>(() => sut.Create("Zombie", true));

            Assert.Equal("Zombie", ex.RequestedEnemyName);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Tests
{
    public class BoosEnemyShould
    {
        private readonly ITestOutputHelper _output;

        public BoosEnemyShould(ITestOutputHelper output)
        {
            _output = output;
        }

        #region Asserting on Floating Point Values
        [Fact]
        [Trait("Category", "Boss")]
        public void HaveCorrectPower()
        {
            //Console.WriteLine("Creating Boss Enemy");
            _output.WriteLine("Creating Boss Enemy");

            BossEnemy sut = new BossEnemy();

            // 1000÷6 = ~166.666666667
            Assert.Equal(166.667, sut.TotalSpecialAttackPower, 3);
        }
        #endregion
    }
}

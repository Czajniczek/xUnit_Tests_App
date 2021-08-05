using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GameEngine.Tests
{
    public class BoosEnemyShould
    {
        #region Asserting on Floating Point Values
        [Fact]
        public void HaveCorrectPower()
        {
            BossEnemy sut = new BossEnemy();

            Assert.Equal(166.667, sut.TotalSpecialAttackPower, 3);
        }
        #endregion
    }
}

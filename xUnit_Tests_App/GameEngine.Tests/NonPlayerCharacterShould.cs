using Xunit;

namespace GameEngine.Tests
{
    public class NonPlayerCharacterShould
    {
        #region Sharing Test Data Across Tests && Getting Test Data from External Sources
        [Theory]
        //[MemberData(nameof(InternalHealthDamageTestData.TestData), MemberType = typeof(InternalHealthDamageTestData))]
        [MemberData(nameof(ExternalHealthDamageTestData.TestData), MemberType = typeof(ExternalHealthDamageTestData))]
        public void TakeDamage(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }
        #endregion
    }
}

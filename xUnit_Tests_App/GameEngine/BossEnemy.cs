namespace GameEngine
{
    public class BossEnemy : Enemy
    {
        public override double TotalSpecialPower => 1000;

        public override double SpecialPowerUses => 6;

        //public bool Check { get; set; }
    }
}

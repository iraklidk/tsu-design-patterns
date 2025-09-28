namespace strategy_demo
{
    internal class RangedAttack : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Performing a ranged attack!");
        }
    }
}
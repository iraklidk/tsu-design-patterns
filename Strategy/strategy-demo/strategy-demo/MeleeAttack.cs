namespace strategy_demo
{
    internal class MeleeAttack : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Performing a melee attack!");
        }
    }
}

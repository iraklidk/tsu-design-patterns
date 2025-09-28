namespace strategy_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a character with a melee attack strategy
            Character warrior = new Character(new MeleeAttack());
            warrior.PerformAttack(); // print we are performing
                                     // melee attack
            // change the character's attack strategy to ranged
            warrior.SetAttackStrategy(new RangedAttack());
            warrior.PerformAttack(); // print changed strategy
        }
    }
}
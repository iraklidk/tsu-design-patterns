namespace strategy_demo
{
    internal class Character
    {
        private IAttackStrategy _attackStrategy;
        public Character(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }
        public void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }
        public void PerformAttack()
        {
            _attackStrategy.Attack();
        }
    }
}

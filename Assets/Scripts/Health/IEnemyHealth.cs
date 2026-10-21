namespace ShootEmUp
{
    public interface IEnemyHealth
    {
        bool IsAlive { get; }
        void TakeDamage(int damage);
    }
}

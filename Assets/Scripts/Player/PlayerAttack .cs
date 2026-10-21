using UnityEngine;

namespace ShootEmUp
{
    public sealed class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private InputManager inputManager;
        [SerializeField] private WeaponComponent weaponComponent;
        [SerializeField] private BulletSystem bulletSystem;
        [SerializeField] private BulletConfig bulletConfig;

        private void FixedUpdate()
        {
            if (this.inputManager.IsFireRequired)
            {
                this.Fire();
                this.inputManager.ConsumeFire();
            }
        }

        private void Fire()
        {
            this.bulletSystem.FlyBulletByArgs(new BulletSystem.Args
            {
                isPlayer = true,
                physicsLayer = (int)this.bulletConfig.physicsLayer,
                color = this.bulletConfig.color,
                damage = this.bulletConfig.damage,
                position = this.weaponComponent.Position,
                velocity = this.weaponComponent.Rotation * Vector3.up * this.bulletConfig.speed
            });
        }
    }
}

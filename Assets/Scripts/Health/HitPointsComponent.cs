using System;
using UnityEngine;

namespace ShootEmUp
{
    public sealed class HitPointsComponent : MonoBehaviour, IEnemyHealth
    {
        public event Action<GameObject> HpEmpty;

        [SerializeField] private int hitPoints;

        public bool IsAlive => this.hitPoints > 0;

        //public bool IsHitPointsExists() {
        //    return this.hitPoints > 0;
        //}

        public void TakeDamage(int damage)
        {
            if (!IsAlive) return;

            this.hitPoints -= damage;
            if (this.hitPoints <= 0)
            {
                this.HpEmpty?.Invoke(this.gameObject);
            }
        }
    }
}
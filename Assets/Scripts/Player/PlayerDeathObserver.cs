using UnityEngine;

namespace ShootEmUp
{
    public sealed class PlayerDeathObserver : MonoBehaviour
    {
        [SerializeField] private HitPointsComponent hitPointsComponent;
        [SerializeField] private GameManager gameManager;

        private void OnEnable()
        {
            this.hitPointsComponent.HpEmpty += this.OnDeath;
        }

        private void OnDisable()
        {
            this.hitPointsComponent.HpEmpty -= this.OnDeath;
        }

        private void OnDeath(GameObject _)
        {
            this.gameManager.FinishGame();
        }
    }
}

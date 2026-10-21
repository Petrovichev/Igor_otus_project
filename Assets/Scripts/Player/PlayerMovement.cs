using UnityEngine;

namespace ShootEmUp
{
    public sealed class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private InputManager inputManager;
        [SerializeField] private MoveComponent moveComponent;

        private void FixedUpdate()
        {
            Vector2 direction = new Vector2(this.inputManager.HorizontalDirection, 0);

            this.moveComponent.MoveByRigidbodyVelocity(direction * Time.fixedDeltaTime);
        }
    }
}
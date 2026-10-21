using UnityEngine;

namespace ShootEmUp
{
    public sealed class InputManager : MonoBehaviour
    {
        public float HorizontalDirection { get; private set; }
        public bool IsFireRequired { get; private set; }

        //[SerializeField] private GameObject character;
        //[SerializeField] private CharacterController characterController;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.IsFireRequired = true;
                //characterController._fireRequired = true; 
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.HorizontalDirection = -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.HorizontalDirection = 1;
            }
            else
            {
                this.HorizontalDirection = 0;
            }
        }

        public void ConsumeFire()
        {
            this.IsFireRequired = false;
        }

        //private void FixedUpdate()
        //{
        //    this.character.GetComponent<MoveComponent>().MoveByRigidbodyVelocity(new Vector2(this.HorizontalDirection, 0) * Time.fixedDeltaTime);
        //}
    }
}
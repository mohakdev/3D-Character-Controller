using UnityEngine;

namespace RadiantTools.CharacterManager
{
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] CharacterSettings characterSettings;
        CharacterController controller;
        Vector3 Velocity;
        float speed;

        void Start()
        {
            speed = characterSettings.walkSpeed;
            controller = GetComponent<CharacterController>();
        }
        void Update()
        {
            MoveJumpCharacter();
            ShiftPress();
        }
        void ShiftPress()
        {
            // Increase speed on shift press
            if (Input.GetKey(KeyCode.LeftShift)) { speed = characterSettings.runSpeed; }
            else { speed = characterSettings.walkSpeed; }
        }
        void MoveJumpCharacter()
        {
            if (controller.isGrounded && Velocity.y < 0)
            {
                Velocity.y = -2f;
            }

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            controller.Move(speed * Time.deltaTime * move);

            Velocity.y += characterSettings.gravity * Time.deltaTime;
            controller.Move(Velocity * Time.deltaTime);

            if (Input.GetButtonDown("Jump") && controller.isGrounded)
            {
                Velocity.y = Mathf.Sqrt(characterSettings.jumpHeight * -2f * characterSettings.gravity);
            }
        }
    }
}

using UnityEngine;

namespace RadiantTools.CharacterManager
{
    [CreateAssetMenu(fileName = "New Character Settings", menuName = "Character Settings")]
    public class CharacterSettings : ScriptableObject
    {
        [Tooltip("Speed of the player without pressing Left Shift")]
        public float walkSpeed;

        [Tooltip("Speed of the player while pressing Left Shift")]
        public float runSpeed;

        public float sensitivity;

        public readonly float gravity = -9.81f;

        [Tooltip("Intensity of the Jump")]
        public float jumpHeight;

        [Tooltip("Maximum health of the Character")]
        public int maxHealth;

        [Tooltip("Current Health of the Character")]
        public int health;
    }
}

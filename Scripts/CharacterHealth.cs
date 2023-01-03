using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantTools.CharacterManager
{
    public class CharacterHealth : MonoBehaviour
    {
        [SerializeField] CharacterSettings charSettings;
        void Start()
        {
            charSettings.health = charSettings.maxHealth;
            Invoke(nameof(TestDamage), 10f);
        }

        void TestDamage()
        {
            TakeCharacterDamage(25);
        }

        public void TakeCharacterDamage(int amount)
        {
            charSettings.health -= amount;
        }
    }
}

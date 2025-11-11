using UnityEngine;

namespace Game.Player
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "PlayerStats")]
    public class PlayerStats : ScriptableObject
    {
        [Header("Config")]
        [SerializeField] private int level = 1;

        [Header("Health")]
        [SerializeField] private float health = 100f;
        [SerializeField] private float maxHealth = 100f;

        public void ReduceHealth(float amount)
        {
            health = Mathf.Clamp(health - amount, 0f, maxHealth);
        }

        public float GetHealth() => health;
        public float GetMaxHealth() => maxHealth;
        public int GetLevel() => level;
    }
}

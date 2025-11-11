using UnityEngine;
using Game.Player;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerHealth : MonoBehaviour, iDamageable
{
    [Header("References")]
    [SerializeField] private PlayerStats playerStats;

    public PlayerAnimations playerAnimations;

    public void Awake()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    public void TakeDamage(float amount)
    {
        if (playerStats == null)
        {
            Debug.LogWarning("PlayerStats não atribuído no Inspector.");
            return;
        }

        playerStats.ReduceHealth(amount);
        Debug.Log($"TakeDamage chamado. Dano: {amount}. Vida atual: {playerStats.GetHealth()}");

        if (playerStats.GetHealth() <= 0f)
        {
            PlayerDead();
        }
    }

    public void PlayerDead()
    {
        Debug.Log("Jogador Derrotado");

        playerAnimations.SetDeadAnimation();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tecla P detectada no Update");
            TakeDamage(1f);
        }
    }
}

using UnityEngine;

namespace Game.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] 
        public PlayerStats playerStats;  // 🔹 Variável privada observável no Inspector

        // 🔹 Propriedade pública para acessar a variável privada
        public PlayerStats Stats => playerStats;
    }
}

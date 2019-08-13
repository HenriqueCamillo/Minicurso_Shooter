using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : Life 
{
    [Tooltip("Quantidade máxima de vida de jogador")]
    [SerializeField] int maxHp;

    /// <summary>
    /// Inicializa a vida do player como a vida máxima
    /// </summary>
    private void Start()
    {
        Hp = maxHp;
    }

    /// <summary>
    /// Restaura toda a vida do jogador
    /// </summary>
    public void RestoreHp()
    {
        Hp = maxHp;
    }

    /// <summary>
    /// Chama o método de Game Over ao morrer
    /// </summary>
    protected override void Die()
    {
        GameManager.instance.GameOver();
    }
}

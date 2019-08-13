using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : Life 
{
    [Tooltip("Pontuação ganha pelo jogador ao destruir este inimigo")]
    [SerializeField] int score;

    /// <summary>
    /// Define o score que o inimigo acrescenta ao ser destruído como a quantidade de vida que ele possui
    /// </summary>
    private void Start()
    {
        score = Hp;
    }

    /// <summary>
    /// Adiciona score ao game manager quando destruído
    /// </summary>
    protected override void Die()
    {
        GameManager.instance.score += score;
    }
}

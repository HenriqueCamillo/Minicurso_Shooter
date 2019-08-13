using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Life : MonoBehaviour
{
    [SerializeField] int hp;
    public int Hp
    {
        get { return hp; }

        // Verifica se a vida acabou sempre que toma dano.
        // Caso tenha acabado, chama a função de morte.
        set
        {
            hp = value;
            if (hp <= 0)
                Die();
        }
    }

    /// <summary>
    /// Função abstrata que é executada quando a nave é destruída
    /// </summary>
    protected abstract void Die();
}

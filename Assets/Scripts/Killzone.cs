using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    [Tooltip("Se ativada, destruirá projéteis que entrarem nessa área")]
    [SerializeField] bool destroyProjectiles;
    [Tooltip("Se ativada, destruirá inimigos que entrarem nessa área")]
    [SerializeField] bool destroyEnemies;

    /// <summary>
    /// Destrói inimigos ou projéteis que entrarem nessa área (dependendo das variáveis de destruir projéteis ou inimigos)
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((destroyEnemies && other.CompareTag("Enemy")) || (destroyProjectiles && other.CompareTag("Projectile")))
            Destroy(other.gameObject);
    }
}
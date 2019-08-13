using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Tooltip("Referência ao componente Rigidbody2D do projétil")]
    [SerializeField] Rigidbody2D rBody;
    [Tooltip("Velocidade do projétil")]
    [SerializeField] float speed = 7;
    [Tooltip("Dano causado em inimigos pelo projétil")]
    [SerializeField] int damage = 5;


    /// <summary>
    /// Coloca o projétil em movimento
    /// </summary>
    private void Start()
    {
        rBody.velocity = Vector2.up * speed;
    }

    /// <summary>
    /// Ao colidir com naves (com inimigos ou com jogador), causa dano
    /// </summary>
    /// <param name="other">O outro colisor</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Player"))
            other.GetComponent<Life>().Hp -= damage;
    }
}
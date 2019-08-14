using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rBody;

    [Tooltip("Velocidade com que a nave desce")]
    [SerializeField] float verticalSpeed;
    [Tooltip("Velocidade com que a nave voa para os lados para perseguir o player")]
    [SerializeField] float horizontalSpeed;

    [Tooltip("Mínima distância horizontal para o player para que a nave pare de se mover horizontalmente")]
    [SerializeField] float horizontalTolerance;
    [Tooltip("Distância da nave após o player para desativar o movimento horizontal")]
    [SerializeField] float verticalTolerance;


    /// <summary>
    /// Pega referência do player e do rigidbody
    /// </summary>
    private void Start()
    {
        player = GameManager.instance.player;
        rBody = GetComponent<Rigidbody2D>();        
    }

    /// <summary>
    /// Faz a nave se mover horizontalmente dependendo da posição do jogador, sempre se movendo para baixo
    /// </summary>
    private void Update()
    {
        // Pega a distância para o jogador
        Vector2 distance = player.transform.position - this.transform.position;

        // Se o inimigo ainda não passou o jogador
        if (distance.y < verticalTolerance)
        {
            // Se o inimigo está à direita, mover à direita
            if (distance.x > horizontalTolerance)
                rBody.velocity = new Vector2(horizontalSpeed, -verticalSpeed);
            // Se estiver à esquerda, mover à esquerda
            else if (distance.x < -horizontalTolerance)
                rBody.velocity = new Vector2(-horizontalSpeed, -verticalSpeed);
            // Se estiver centrlizado o suficiente, não mover verticalmente
            else
                rBody.velocity = new Vector2(0f, -verticalSpeed);
        }
        // Se já passou o jogador, não mover verticalmente
        else
        {
            rBody.velocity = new Vector2(0f, -verticalSpeed);
        }
    }
}

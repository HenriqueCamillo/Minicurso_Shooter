using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Tooltip("Velocidade da nave do jogador")]
    [SerializeField] float speed = 5f;
    private Vector2 movementDirection;
    private Rigidbody2D rBody;


    /// <summary>
    /// Pega referência do componente responsável pela física do objeto
    /// </summary>
    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();        
    }

    /// <summary>
    /// Pega o input das setas do jogador, cria um vetor com elas, e define 
    /// a velocidade do jogador de acordo com esse vetor e a velocidade
    /// </summary>
    private void Update()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        rBody.velocity = movementDirection * speed;
    }
}

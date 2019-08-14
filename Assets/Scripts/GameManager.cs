using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Referência estática ao Game Manager
    public static GameManager instance;

    [Tooltip("Quantidade de pontos objtidos pelo jogador até o momento")]
    public int score = 0;

    [Tooltip("Referência ao player, para facilitar o acesso")]
    public GameObject player;

    /// <summary>
    /// Verifica condição de singleton, e busca o player caso necessário
    /// </summary>
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this.gameObject);


        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
    }

    /// <summary>
    /// 
    /// </summary>
    public void GameOver()
    {
        Debug.Log("game over");
    }
}

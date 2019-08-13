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

    /// <summary>
    /// Verifica condição de singleton
    /// </summary>
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this.gameObject);
    }

    /// <summary>
    /// 
    /// </summary>
    public void GameOver()
    {
        Debug.Log("game over");
    }
}

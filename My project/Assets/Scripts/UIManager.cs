using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    TextMeshProUGUI pontos, pontFinal, record;
    GameObject gameOverWindow;

    private void Start()
    {
        gameOverWindow.SetActive(false);
    }
    public void updateScoreText()
    {
        // Atualiza o texto de `scoreText` com a pontua��o atual do `GameManager`.
    }


    public void gameOver()
    {
        // pontFinal = (pontua��o final do gameManager)
        // Atualiza o texto de `recordText` com o recorde armazenado nas prefer�ncias do jogador.
        gameOverWindow.SetActive(true);
        Time.timeScale = 0;
    }

}

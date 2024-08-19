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
        // Atualiza o texto de `scoreText` com a pontuação atual do `GameManager`.
    }


    public void gameOver()
    {
        // pontFinal = (pontuação final do gameManager)
        // Atualiza o texto de `recordText` com o recorde armazenado nas preferências do jogador.
        gameOverWindow.SetActive(true);
        Time.timeScale = 0;
    }

}

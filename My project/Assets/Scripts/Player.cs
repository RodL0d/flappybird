using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    int velocity = 5;

   // ManagerUI managerUI

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rigidbody2D.AddForce(transform.up * velocity);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rigidbody2D.gameObject.CompareTag("Obstacle"))
        {
            //gameOver
        }
        if (rigidbody2D.gameObject.CompareTag("Score"))
        {
            // Incrementa a pontuação no `GameManager`.
            // Atualiza o texto da pontuação na interface do usuário.
        }

    }

    private void GameOver()
    {
        // Verifica se a pontuação atual é maior que o recorde armazenado.
        {
            // Se for maior, atualiza o recorde nas preferências do jogador.
        }
        // Chama o método `GameOver` no `UIManager` para exibir a tela de Game Over.
    }

}

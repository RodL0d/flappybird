using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    

public class SpawnManager : MonoBehaviour
{
    // Cron�metro para controlar o tempo entre as inst�ncias
    private float clock;

    // Tempo de espera entre a cria��o de novos objetos
    [SerializeField] private float cooldown = 2f;

    // Prefab a ser instanciado
    [SerializeField] private GameObject prefab;

    // Update � chamado uma vez por frame
    private void Update()
    {
        // Verifica se o cron�metro `clock` atingiu zero ou menos
        if (clock <= 0f)
        {
            // Reseta o cron�metro `clock` para o valor de `cooldown`
            clock = cooldown;

            // Define a posi��o x correspondente ao limite da tela (lado direito)
            float spawnX = 10f; // Alterar para o valor correspondente ao limite direito da tela
            // Define uma posi��o y aleat�ria entre -2 e 2
            float spawnY = Random.Range(-2f, 2f);

            // Instancia o prefab na posi��o calculada com rota��o padr�o
            Instantiate(prefab, new Vector3(spawnX, spawnY, 0f), Quaternion.identity);
        }
        else
        {
            // Se o cron�metro ainda n�o atingiu zero, subtrai o valor de `Time.deltaTime` do cron�metro
            clock -= Time.deltaTime;
        }
    }
}

}

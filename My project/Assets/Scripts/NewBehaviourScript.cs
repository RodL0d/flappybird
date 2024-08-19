using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    

public class SpawnManager : MonoBehaviour
{
    // Cronômetro para controlar o tempo entre as instâncias
    private float clock;

    // Tempo de espera entre a criação de novos objetos
    [SerializeField] private float cooldown = 2f;

    // Prefab a ser instanciado
    [SerializeField] private GameObject prefab;

    // Update é chamado uma vez por frame
    private void Update()
    {
        // Verifica se o cronômetro `clock` atingiu zero ou menos
        if (clock <= 0f)
        {
            // Reseta o cronômetro `clock` para o valor de `cooldown`
            clock = cooldown;

            // Define a posição x correspondente ao limite da tela (lado direito)
            float spawnX = 10f; // Alterar para o valor correspondente ao limite direito da tela
            // Define uma posição y aleatória entre -2 e 2
            float spawnY = Random.Range(-2f, 2f);

            // Instancia o prefab na posição calculada com rotação padrão
            Instantiate(prefab, new Vector3(spawnX, spawnY, 0f), Quaternion.identity);
        }
        else
        {
            // Se o cronômetro ainda não atingiu zero, subtrai o valor de `Time.deltaTime` do cronômetro
            clock -= Time.deltaTime;
        }
    }
}

}


using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock = 3;
    float cooldown = 2.5f;
    

    public GameObject prefab;

    

    



    IEnumerable Update() 
    { 
        {
           
            float spawnX = 10f; 
            float spawnY = Random.Range(-2f, 2f);

            
            Instantiate(prefab, new Vector3(spawnX, spawnY, 0f), Quaternion.identity);

            yield return new WaitForSeconds(5);
        }

        
    
    }
}



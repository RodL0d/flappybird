using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock;
    float cooldown = 2.5f;

    
    public GameObject prefab;

    void Start()
    {
        
        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
    private void Update()
    {
        




        void Update()
        {
            if (clock <= 0)
            {
                clock -= Time.deltaTime;
            }
            else
            {
                clock = cooldown;
            }
        }

        
    
    }
}



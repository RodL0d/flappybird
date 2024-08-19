using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    #region Singleton
    

    
    
        

    public static GameManager instance;

    
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion
    int score;
    public int Score { get => Score; set => Score = value; }

    void CheackPosition()
    {
        var distanceZ = (transform.position - Camera.main.transform.position).z;

        var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).x;

        var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceZ)).x;

        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).y;

        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distanceZ)).y;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
            Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
            transform.position.z
        );
    }
}



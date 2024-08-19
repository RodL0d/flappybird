using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mudarcena : MonoBehaviour
{
  public void ChangeScene()
    {
        SceneManager.LoadScene("Game");
    }
}

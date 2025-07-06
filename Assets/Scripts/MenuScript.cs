using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   public void changeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
        Debug.Log("test");
    }
}

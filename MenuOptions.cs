using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuOptions : MonoBehaviour
{
    public static bool IsLoading = false;
    
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        IsLoading = true;
        SceneManager.LoadScene(1);
    }
}

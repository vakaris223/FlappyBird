using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managerMenu : MonoBehaviour
{
    public void playGame()
    {
         SceneManager.UnloadScene("menu");
        SceneManager.LoadScene("bird");
    }
}

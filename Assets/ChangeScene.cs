using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("GameClear");
        }
        if (Input.GetKey(KeyCode.Backspace))
        {
            SceneManager.LoadScene("Gameover");
        }
    }
}

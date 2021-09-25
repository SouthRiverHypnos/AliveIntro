using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object that entered the trigger : " + other);
        LoadNextScene();
    }

    public void LoadNextScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

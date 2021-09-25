using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject EndScreen;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object that entered the trigger : " + other);
        EndScreen.SetActive(true);
        BGM.Instance.gameObject.GetComponent<AudioSource>().Stop();
    }

     void Start()
    {
        EndScreen.SetActive(false);
    }


}

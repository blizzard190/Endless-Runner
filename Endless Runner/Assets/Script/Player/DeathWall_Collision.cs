using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathWall_Collision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "DeathTrigger")
        {
            SwitchScene("Menu");
        }
    }
    void SwitchScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
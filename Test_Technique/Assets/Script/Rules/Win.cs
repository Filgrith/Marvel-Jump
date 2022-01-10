using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winScreen;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            Time.timeScale = 0f;
            winScreen.SetActive(true);
        }
    }
}

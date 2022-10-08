using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
  [SerializeField]private string level2;

    void OnTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("newlevel2");
        }
    }
}

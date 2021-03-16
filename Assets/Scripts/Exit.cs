using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] private int sceneIndex;
    [SerializeField] private int entranceIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("Entrance Index", entranceIndex);
            SceneManager.LoadScene(sceneIndex);
        }
    }
}

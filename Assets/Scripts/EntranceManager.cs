using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceManager : MonoBehaviour
{
    [SerializeField] private Transform[] entrances;
    [SerializeField] private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Entrance Index"))
            player.position = entrances[PlayerPrefs.GetInt("Entrance Index")].position;
    }
}

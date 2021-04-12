using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EntranceManager : MonoBehaviour
{
    public Transform[] entrances;

    private void Start()
    {
        Player.instance.MoveToEntrance(entrances);
    }
}

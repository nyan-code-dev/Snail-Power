using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EntranceManager : MonoBehaviour
{
    private void Start()
    {
        List<Transform> children = new List<Transform>();
        foreach(Transform t in transform)
        {
            children.Add(t);
        }
        Player.instance.MoveToEntrance(children.ToArray());
    }
}

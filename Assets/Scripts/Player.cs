using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public PlayerInput input;
    [HideInInspector] public PlayerMove move;
    [HideInInspector] public PlayerLamp lamp;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
        move = GetComponent<PlayerMove>();
        lamp = GetComponent<PlayerLamp>();
        input.player = this;
        move.player = this;
        lamp.player = this;
    }
}

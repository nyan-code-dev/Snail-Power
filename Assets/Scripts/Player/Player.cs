using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public PlayerInput input;
    [HideInInspector] public PlayerMove move;
    [HideInInspector] public PlayerLamp lamp;
    [HideInInspector] public PlayerCombat combat;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
        move = GetComponent<PlayerMove>();
        lamp = GetComponent<PlayerLamp>();
        combat = GetComponent<PlayerCombat>();
        input.player = this;
        move.player = this;
        lamp.player = this;
        combat.player = this;
    }
}

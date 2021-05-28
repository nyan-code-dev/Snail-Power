using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [HideInInspector] public Player player;
    private InputMaster controls;

    private void Awake()
    {
        controls = new InputMaster();
        controls.Player.JumpStart.performed += _ => player.move.JumpStart();
        controls.Player.JumpEnd.performed += _ => player.move.JumpEnd();
        controls.Player.Movement.performed += _ => player.move.Movement(_.ReadValue<float>());
        controls.Player.Slash.performed += _ => player.combat.Slash();
        controls.Player.Up.performed += _ => player.Interact();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}

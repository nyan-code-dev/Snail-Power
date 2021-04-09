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
        controls.Player.QuickAction.performed += _ => player.lamp.OnOff();
        controls.Player.Slash.performed += _ => player.combat.Slash();
    }
    // Start is called before the first frame update
    void Start()
    {
        
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

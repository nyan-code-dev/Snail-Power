using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLamp : MonoBehaviour
{
    [HideInInspector] public Player player;
    [SerializeField] private ShellType lightShell;

    [SerializeField] private Shell startShell;
    [SerializeField] private Shell.ShellSize allowedShellSize;
    [SerializeField] private float energyTime;

    private float timeLeft;
    private bool lampOn;

    // Start is called before the first frame update
    void Start()
    {
        PutShell(startShell);
    }

    // Update is called once per frame
    void Update()
    {
        if (lampOn)
        {
            
        }
    }

    void PutShell(Shell newShell)
    {
        if (newShell.type != lightShell)
        {
            Debug.LogError("The shell is not of type lightShell");
        }
        else if (newShell.size != allowedShellSize)
        {
            Debug.Log("The shell is not of the expected size");
        }
        else
        {
            if (newShell.isCharged)
            {
                timeLeft = energyTime;
            }
            else
            {
                timeLeft = 0;
            }
        }
    }

    public void OnOff()
    {
        lampOn = !lampOn;
    }
}

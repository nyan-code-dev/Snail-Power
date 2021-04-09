using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellTool : MonoBehaviour
{
    [SerializeField] private ShellType type;
    [SerializeField] private Shell.ShellSize allowedShellSize;

    public float ChargedAmount
    {
        get
        {
            return currentShell.chargedAmount;
        }
        set
        {
            currentShell.chargedAmount = Mathf.Clamp(value, 0, 1);
        }
    }

    private Shell currentShell;

    public void ShellPut(Shell newShell)
    {
        if (newShell == null)
        {
            currentShell = null;
        }
        else if (newShell.type != type)
        {
            Debug.LogError("The shell is not of type lightShell");
        }
        else if (newShell.size != allowedShellSize)
        {
            Debug.Log("The shell is not of the expected size");
        }
        else
        {
            currentShell = newShell;
        }
    }
}

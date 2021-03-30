using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Shell
{
    public enum ShellSize
    {
        tiny,
        small,
        medium,
        big,
        huge
    }

    public ShellType type;
    public ShellSize size;
    /// <summary>
    /// Number from 0 to 1 saying how much the shell is charged
    /// </summary>
    [Range(0, 1)]
    public float chargedAmount;
}

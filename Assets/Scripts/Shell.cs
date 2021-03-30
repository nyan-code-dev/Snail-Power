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

    public bool isCharged;
}

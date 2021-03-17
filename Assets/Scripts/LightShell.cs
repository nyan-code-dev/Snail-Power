using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LightShell : Shell
{
    public float LightRange => 2.5f + size / 3;

    public override float MaxEnergy => 6 + size / 2;
}

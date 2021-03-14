using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Shell
{
    /// <summary>
    /// Size of the shell from 1~5, it affects capacity of the shell and time to fill up
    /// </summary>
    [Range(1, 5)]
    public float size = 1;

    /// <summary>
    /// If the shell is charged and ready to use or not
    /// </summary>
    public bool isCharged;

    /// <summary>
    /// The enrgy left in the shell, set equal to max energy when charged
    /// </summary>
    /*[HideInInspector]*/ public float energyLeft;

    /// <summary>
    /// The time the shell takes to charge relative to the size, varies between some types of shell
    /// </summary>
    public virtual float TimeToCharge => size;

    /// <summary>
    /// The maximum amount of energy the shell has
    /// </summary>
    public virtual float MaxEnergy => size * 5;
}

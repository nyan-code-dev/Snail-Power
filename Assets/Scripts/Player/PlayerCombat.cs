using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [HideInInspector] public Player player;

    private bool slashing;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Slash()
    {
        if (!slashing)
        {
            anim.SetTrigger("Slash");
            slashing = true;
        }
    }

    public void SlashDamage()
    {
        Debug.Log("Damaging by Slash");
    }

    public void EndSlash()
    {
        slashing = false;
    }
}

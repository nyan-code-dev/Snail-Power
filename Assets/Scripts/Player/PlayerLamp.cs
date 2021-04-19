using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLamp : ShellTool
{
    [HideInInspector] public Player player;
    [HideInInspector] public Slider lampSlider;

    [SerializeField] private GameObject defaultLight;
    [SerializeField] private GameObject lampLight;

    [SerializeField] private float energyTime;
    [SerializeField] private Shell startShell;

    private float deltaMultiplier => 1 / energyTime;
    private bool lampOn;

    // Start is called before the first frame update
    void Start()
    {
        ShellPut(startShell);
    }

    // Update is called once per frame
    void Update()
    {
        if (lampOn)
        {
            ChargedAmount -= Time.deltaTime * deltaMultiplier;
            lampSlider.value = ChargedAmount;
            if (ChargedAmount == 0)
            {
                Off();
            }
        }
    }

    public void OnOff()
    {
        if (lampOn)
        {
            Off();
        }
        else
        {
            On();
        }
    }

    void On()
    {
        lampOn = true;
        defaultLight.SetActive(false);
        lampLight.SetActive(true);
    }

    void Off()
    {
        lampOn = false;
        defaultLight.SetActive(true);
        lampLight.SetActive(false);
    }
}

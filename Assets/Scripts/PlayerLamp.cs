using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

public class PlayerLamp : MonoBehaviour
{
    [HideInInspector] public Player player;

    [SerializeField] private LightShell shell;
    [SerializeField] private GameObject defaultLight;
    [SerializeField] private GameObject lampLight;
    [SerializeField] private Slider lampBar;

    private bool lampOn;

    // Start is called before the first frame update
    void Start()
    {
        lampLight.GetComponent<Light2D>().pointLightOuterRadius = shell.LightRange;
        shell.energyLeft = shell.MaxEnergy;
        lampBar.maxValue = shell.MaxEnergy;
        lampBar.value = shell.energyLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (lampOn)
        {
            shell.energyLeft -= Time.deltaTime;
            lampBar.value = shell.energyLeft;
            if (shell.energyLeft <= 0)
            {
                shell.isCharged = false;
                lampOn = false;
                defaultLight.SetActive(true);
                lampLight.SetActive(false);
            }
        }
    }

    public void OnOff()
    {
        if (lampOn)
        {
            lampOn = false;
            defaultLight.SetActive(true);
            lampLight.SetActive(false);
        }
        else
        {
            if (shell.isCharged)
            {
                lampOn = true;
                defaultLight.SetActive(false);
                lampLight.SetActive(true);
            }
        }
    }
}

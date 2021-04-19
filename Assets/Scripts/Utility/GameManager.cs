using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Slider lampSlider;
    [SerializeField] private CinemachineVirtualCamera vCamera;

    // Start is called before the first frame update
    void Start()
    {
        Player.instance.lamp.lampSlider = lampSlider;
        vCamera.Follow = Player.instance.transform;
    }
}

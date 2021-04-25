using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera vCamera;

    // Start is called before the first frame update
    void Start()
    {
        vCamera.Follow = Player.instance.transform;
    }
}

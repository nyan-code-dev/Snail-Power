using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollowSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CinemachineVirtualCamera>().Follow = Player.instance.transform;
    }
}

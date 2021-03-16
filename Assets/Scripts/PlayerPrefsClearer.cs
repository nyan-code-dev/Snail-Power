using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerPrefsClearer : MonoBehaviour
{
    // Remeber to do this also when starting game from application
    [InitializeOnEnterPlayMode]
    static void OnEnterPlayMode()
    {
        PlayerPrefs.DeleteKey("Entrance Index");
    }
}

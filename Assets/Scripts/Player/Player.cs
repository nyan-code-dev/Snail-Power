using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player instance;

    [HideInInspector] public PlayerInput input;
    [HideInInspector] public PlayerMove move;
    [HideInInspector] public PlayerLamp lamp;
    [HideInInspector] public PlayerCombat combat;

    private int? entranceIndex;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
        move = GetComponent<PlayerMove>();
        lamp = GetComponent<PlayerLamp>();
        combat = GetComponent<PlayerCombat>();
        input.player = this;
        move.player = this;
        lamp.player = this;
        combat.player = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Exit exit))
        {
            SceneManager.LoadScene(exit.sceneIndex);
            entranceIndex = exit.entranceIndex;
        }
    }

    public void MoveToEntrance(Transform[] entrances)
    {
        if (entranceIndex != null)
        {
            transform.position = entrances[entranceIndex.GetValueOrDefault()].position;
        }
    }
}
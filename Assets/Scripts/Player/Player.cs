using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player instance;

    [HideInInspector] public PlayerInput input;
    [HideInInspector] public PlayerMove move;
    [HideInInspector] public PlayerCombat combat;

    [SerializeField] private float invincibilityTime;
    private bool recievesDamage = true;
    [SerializeField] private int health = 3;

    private int? entranceIndex;
    private Door currentDoor;

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
        combat = GetComponent<PlayerCombat>();
        input.player = this;
        move.player = this;
        combat.player = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Exit exit))
        {
            SceneManager.LoadScene(exit.sceneIndex);
            entranceIndex = exit.entranceIndex;
        }
        else if (collision.TryGetComponent(out Door door))
        {
            door.enterText.SetActive(true);
            currentDoor = door;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (recievesDamage && collision.CompareTag("Enemy"))
        {
            Debug.Log("Touched enemy");
            recievesDamage = false;
            health--;
            if (health <= 0)
            {
                Debug.Log("PLAYER IS DEAD");
            }
            StartCoroutine(InvincibilityTime());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (currentDoor != null && collision.gameObject == currentDoor.gameObject)
        {
            currentDoor.enterText.SetActive(false);
            currentDoor = null;
        }
    }

    IEnumerator InvincibilityTime()
    {
        yield return new WaitForSeconds(invincibilityTime);
        recievesDamage = true;
    }

    public void MoveToEntrance(Transform[] entrances)
    {
        if (entranceIndex != null)
        {
            transform.position = entrances[entranceIndex.GetValueOrDefault()].position;
        }
    }

    public void EnterDoor()
    {
        if (move.isGrounded && currentDoor)
        {
            SceneManager.LoadScene(currentDoor.sceneIndex);
            entranceIndex = currentDoor.entranceIndex;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoader : MonoBehaviour
{
    public delegate void LoadMap(int mapIndex, int? entranceIndex);
    public static LoadMap loadMap;

    [SerializeField] private Transform player;
    [SerializeField] private GameObject[] maps;

    private GameObject map;

    // Start is called before the first frame update
    void Start()
    {
        loadMap = MapLoad;
        MapLoad(0, null);
    }

    void MapLoad(int mapIndex, int? entranceIndex)
    {
        if (map != null)
            map.SetActive(false);
        Destroy(map);
        map = Instantiate(maps[mapIndex]);
        if (entranceIndex != null)
        {
            player.position = map.GetComponent<EntranceManager>().entrances[entranceIndex ?? 0].position;
        }
    }
}

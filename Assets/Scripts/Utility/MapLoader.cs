using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MapLoader : MonoBehaviour
{
    public delegate void LoadMap(int mapIndex, int? entranceIndex);
    public static LoadMap loadMap;

    [SerializeField] private Transform player;
    [SerializeField] private CinemachineConfiner cameraConfiner;
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
        cameraConfiner.m_BoundingShape2D = map.GetComponent<PolygonCollider2D>();
        if (entranceIndex != null)
        {
            player.position = map.GetComponent<EntranceManager>().entrances[entranceIndex ?? 0].position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChapterOn : MonoBehaviour
{
    public static SpawnChapterOn instance;
    [Header("PlayerSpawnPoint")]

    public Vector2 spawnPoint;
    public GameObject spawnTransform1;
    public GameObject spawnTransform2;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        spawnPoint.x = spawnTransform1.transform.position.x;
        spawnPoint.y = spawnTransform1.transform.position.y;
        transform.position = spawnPoint;
    }

   
    void Update()
    {
        
    }

    public void SpawnChapter1()
    {

    }
}

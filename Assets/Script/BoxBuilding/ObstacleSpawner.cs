using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
     public GameObject obsPrefab;

    GamePlayController moveCount;
    //private int movePoint=3;

    void Start()
    {
        
    }

    public void SpawnObs()
    {
        Instantiate(obsPrefab, new Vector3(0, 0, 1f), Quaternion.identity);

        /*
        GameObject obsObj = Instantiate(obsPrefab);

        Vector3 temp = transform.position;
        temp.z = 1f;

        obsObj.transform.position = temp; */
    }

    /*
    public void MovePointSpawn()
    {
        if(movePoint == moveCount.moveCount)
        {
            transform.position += new Vector3( transform.position.x, (transform.position.y + 1f)*Time.deltaTime, transform.position.z);
        }
    }
    */
}

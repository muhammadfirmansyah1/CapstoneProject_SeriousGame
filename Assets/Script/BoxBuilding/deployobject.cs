using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployobject : MonoBehaviour
{
    public GameObject ObjectPrefab;
    public float respawnTime = 5f;
    private Vector2 screenBounds;

    public GameObject[] objects;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ObjectWave());
    }

    private void spawnEnemy()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }

    IEnumerator ObjectWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToCatch : MonoBehaviour
{
    public static ObjectToCatch _objectToCatch;
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    public int amountScoreObj;

    void Awake()
    {
        if(_objectToCatch == null)
        {
            _objectToCatch = this;
        }
        else
        {
            Destroy(_objectToCatch);
        }
    }

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Random.Range(0, -speed));
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    // Update is called once per frame
    void Update()
    {
            if(transform.position.y < screenBounds.y * -2)
            {
                Destroy(this.gameObject);
            }
        
    }
}

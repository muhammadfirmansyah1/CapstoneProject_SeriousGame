using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatterDisappear : MonoBehaviour
{
  
    public float moveSpeed =3f;
    private Vector3 moveDirection;
    public float deceleration = 5f;
    public float lifetime = 3f;
    public SpriteRenderer theSR;
    public float fadeSpeed =2f;

    void Start()
    {
        
    }
    void Update()
    {
        lifetime -= Time.deltaTime;

        if(lifetime < 0)
        {
            theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, Mathf.MoveTowards(theSR.color.a, 0f, fadeSpeed * Time.deltaTime));
            if(theSR.color.a == 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController _camera;
    [SerializeField] GameObject thingToFollow;

    private void Awake()
    {
        _camera = this;
    }

    void LateUpdate() 
    {
            transform.position = thingToFollow.transform.position + new Vector3 (0,0, -10);
    }
}

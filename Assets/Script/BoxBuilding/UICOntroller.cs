using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICOntroller : MonoBehaviour
{
    public static UICOntroller instance;
    // Start is called before the first frame update

    public GameObject finishScreen;
    
    private void Awake() {
        instance = this;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

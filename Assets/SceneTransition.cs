using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public Animator transitionAnimScene;
    // Start is called before the first frame update
    void Start()
    {
        transitionAnimScene.GetComponent< Animator >().updateMode = AnimatorUpdateMode.UnscaledTime;
        transitionAnimScene.SetTrigger("end");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

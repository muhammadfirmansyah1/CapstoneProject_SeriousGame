using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardController : MonoBehaviour
{
    [SerializeField] public Transform bodyWizard;
    void Start()
    {
        
    }
    void Update()
    {
        var EnemyPosition = bodyWizard.transform.position.x;
        var MCPosition = PlayerController.instance.transform.position.x;
        if(EnemyPosition > MCPosition) 
            {
                 bodyWizard.localScale = Vector3.one;
            }
            else
            {
                bodyWizard.localScale = new Vector3(-1f,1f,1f);
            }}}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENmy : MonoBehaviour
{

    private Animator _anim;
    private Rigidbody rg;
    private spawn _spanw;
    public bool _idle = false;


    private void Start()
    {
    
        _spanw = GameObject.FindGameObjectWithTag("spawnenemy").GetComponent<spawn>();
        _anim = GetComponent<Animator>();
        rg = GetComponent<Rigidbody>();

    }


    private void Update()
    {
        if (_spanw._run)
        {

  
        _anim.SetBool("run",true);
        rg.velocity = Vector3.forward * 12;
           

        }
     
            
         
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="stop")
        {
            _anim.SetBool("run", false);
            rg.velocity = Vector3.forward * 0;
        }
    }


}

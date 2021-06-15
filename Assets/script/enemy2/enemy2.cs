using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    /*  
    AYNI ŞEKİLDE ENMYLER İÇİNDE DAHA AZ KOD KULLANMA AMAÇLI KALITIM KULLANABİLİRDİM BİRAZ ARAŞTIRMA YAPTIM ÖNCEDEN BİLSEYDİM BURDA KALITIM KULLANMAYI TERCİH EDERDİM 

     */
    private Animator _anim;
    private Rigidbody rg;
    private spawnenemy _spanw;
    public bool _idle = false;

 
    private void Start()
    {
        _spanw = GameObject.FindGameObjectWithTag("enemymotor").GetComponent<spawnenemy>();
        
        _anim = GetComponent<Animator>();
        rg = GetComponent<Rigidbody>();

    }


    private void Update()
    {
        if (_spanw._run)
        {
            rg.velocity = Vector3.forward * 12;
            _anim.SetBool("runner", true);
        }
     
        


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "stop")
        {
            _anim.SetBool("runner", false);
            rg.velocity = Vector3.forward * 0;
           
           
           
        }
    }

}

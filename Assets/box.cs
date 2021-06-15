using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    private spawn _spanw; 
    private spawnenemy _spanwEnemy;
    private ENmy _enemy;


    private void Start()
    {
        _spanw = GameObject.FindGameObjectWithTag("spawnenemy").GetComponent<spawn>(); 
        _spanwEnemy = GameObject.FindGameObjectWithTag("enemymotor").GetComponent<spawnenemy>();
        _enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<ENmy>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            _spanw._run = false;


        }  if (other.gameObject.tag == "enemy2")
        {

            _spanwEnemy._run = false;


        }
    }


}

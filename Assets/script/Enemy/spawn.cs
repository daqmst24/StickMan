using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{


    [SerializeField] GameObject _spawn;
    private bitisscript _bitis;
    [SerializeField] Transform _enemy;
    [SerializeField] bitisscript _bitti;

    [SerializeField] int _ilkSayi;
    [SerializeField] int _sonSayı;

    public int _girlScore;

    public bool _run=false;

    public string _yellowName = "Sarı Oyuncu";
    public float _number;
    float value = 0;

  

    private int _artis=1;
    private void Start()
    {
        _number = Random.Range(1, 5);
    }



    void Update()
    {
     
        if (_bitti._devam==false)
        {

       
    
            if (value < _number)
            {
                value += 0.01f;
            }
            else
            {
            
            value = 0;
                _girlScore++;
            Instantiate(_spawn, new Vector3(_enemy.position.x, _enemy.position.y, 1.3f * _artis), Quaternion.identity);
            _artis++;
            _run = true;
     
         
               
        
            }
        }

    }




   


}

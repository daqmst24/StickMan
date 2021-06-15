using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemy : MonoBehaviour
{
    /* BUNLAR YERİNE ŞİMDİ DİYOM KEŞKİ KALITIM UYGULASAYDIM KODAN DAHA FAZLA TASARUF EDİP SİSTEMİ DAHA RAHATLATIRDIM*/
    [SerializeField] GameObject _spawn;
    private bitisscript _bitis;
    [SerializeField] Transform _enemy;
    [SerializeField] bitisscript _bitti;

    public bool _run = false;


    public int _motorScore;


    public float _number;
    float value = 0;

    public string _greenName = "Yeşil Oyuncu";

    private int _artis = 1;

    private void Start()
    {
        _number = Random.Range(1, 5);
    }



    void Update()
    {

        
        if (_bitti._devamEnemy==false)
        {



            if (value < _number)
            {
                value += 0.01f;
            }
            else
            {
               
             
                value = 0;
                Instantiate(_spawn, new Vector3(_enemy.position.x, _enemy.position.y, 1.3f * _artis), Quaternion.identity);
                _motorScore++;
                _artis++;
                _run = true;
     



            }
        }

    }
}

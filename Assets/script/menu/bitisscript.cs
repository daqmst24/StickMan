using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bitisscript : MonoBehaviour
{

    [SerializeField] GameObject _winner;

    public bool _devam=false;
    public bool _devamEnemy=false;
   private float say,say2,say3;
 
    [SerializeField] Text text;
 
    private int _time=0;
  private GameObject _scoreList;

    /*
    BURDA İSE ASALINDA ŞEY DÜŞÜDÜM SPAWNLAMAYI MESELA KELİME OYUNDAKİ OYUNU YAPAN KİŞİ MESUT DAG YAZIYOYA
    ÖRNEK LEGHT ALIRDIM LEGHT 27 BUNUN KUPLERİ SPAWNLANMA YNAİ Z ROTASYONUNU ALIP ÖRNEK:27* UP ARASI MESAFE SPAWNI 2 OLSUN 27*2 DİYİP BUNU SONUNA SPAWN EDEBİLLRİDİM
    DAHA HOŞ Bİ SİSTEM OLURDDU YARIN ÖBÜRGÜN KELİMEYİ DEĞİŞTRİDİMİ BİTİŞ NOKTASINDA OYNAMAYA YAPMAMA GEREK KALMAZDI ZATEN SPAWN VE YAZI OALYLARI İÇİME SİNDİ GÜZEL Bİ 
    SPAWN OLAYI OLARAK DÜŞÜNÜYOM BU SEVİYEYE GÖRE BAŞKA YORUM YAPABİLCEĞİN Bİ KONU OLURSA ABİ WASAPTAN YAZARSIN HATAMIZA BAKARIZ.
     

     */

    private void Start()
    {
        _scoreList = GameObject.FindGameObjectWithTag("scoreListr");
    }



    public  void Bitti()
    {

        _scoreList.SetActive(false);
        _time++;
        _devam = true;
        _devamEnemy = true;

     

       
        switch (_time)
        {
            case 1:
                text.text = "1. Oldun";
                _winner.SetActive(true);
                Time.timeScale = 0;

                break;
            case 2:
                text.text = "2. Oldun";
                _winner.SetActive(true);
                Time.timeScale = 0;

                break;
            default:
                text.text = "3. Oldun";
                _winner.SetActive(true);
                Time.timeScale = 1;
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
           
            Time.timeScale = 0;
            Bitti();

        }  
        if (other.gameObject.tag=="Enemy")
        {
            _devam = true;
            float say2 = _time;
            Debug.Log(say2);
            _time++;

           
            

        }    
        if (other.gameObject.tag=="enemy2")
        {
            _devamEnemy = true;
            float say3 = _time;
      
            Debug.Log(say3);
            _time++;
        


        }
       
     
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string _kelime = "oyunu yapan kişi mesut dag";
    public int _sayı = 0;


    public string _playerName = "Beyaz Oyuncu";

    public bool aktif = false;
    public bool _yanlis = false;
    public char tutucu;
    public bool _bitisEkranı = false;
    [SerializeField] Text _yazı;
    public int sayı;
    public bool _walk = false;
    public int _hiz = 0;
    private bool _devamEt = false;
    private AudioSource _audio;
    [SerializeField] AudioClip _false;
    [SerializeField] AudioClip _skor;
    [SerializeField] AudioClip _dontSkor;
    public int _puan = 0;
    [SerializeField] Text _puanText;
    [SerializeField] Text _puanOyunSonu;
    private Animator _anim;
    private int _bitisSayı = 0;
    [SerializeField] bitisscript _bitis;
    private bool _keyborD = false;
    /* DENEME AMAÇLI BİRAZ FAZLA KOD KULLANDIM ABİ KUSURA BAKMA
     İLERDE DAHA GÜZEL KULLANICAM ADAM AKILI HEMDE.
    İNŞİLLAH BEĞENİRSİN ABİ BEN YAPTIĞIM İŞİ DAHA OLABİLLİCEĞİNE İNANIYOM YANİ DAHA GÜZEL YAPABİLLİRDİM AMA ŞUANLIK 4-5 AY BAŞLAYAN BİRİNE GÖRE İYİ OLDUĞUMU HİSEDİYOM.
     
     */
    [SerializeField] private Text _kelimee;
    private string _harf;
    [SerializeField] GameObject _spawn;
    [SerializeField] Transform _kup;
    TouchScreenKeyboard _keybord;
    private Rigidbody _rg;

    private string _kelimeTutulan;
    [SerializeField] Text _ilktest;
    [SerializeField] Text _ikincitext;
    [SerializeField] Text _ucuncutext;


    public bool _dondu=true;


    [SerializeField] spawn _spawnScript;
    [SerializeField] spawnenemy _spawnEnemy;

    private void Start()
    {




 

        _rg = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();



    }
    private void Update()
    {

        TekerlikDongusu(_dondu);


        if (!_keyborD)
        {
            _keybord = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        }
        else
        {
            _keybord.active = true;
        }


        _kelimeTutulan = _keybord.text;


        /*PUANLAMA SİSTEMİ DAHA İYİ OLABİLİRDİ.
          AKLIMA ŞU SORU HEP GELDİ BURAYA Bİ PLAYER DAHA EKLESEM BAŞTAN HEPSİNİ DEĞİŞTİRMEK 
        SAÇMA OLUCAK BUNUN İÇİN DAHA İYİ BİR SİSTEM VARDIR DİYE DÜŞÜNÜM İLERLİYEN ZMANLARDA 
        ELİMDEN GELENİN DAHA İYİSİNİ YAPMAYA GAYRET GÖSTERİCEM.
        */

        if (_puan > _spawnScript._girlScore && _puan > _spawnEnemy._motorScore)
        {
            _ilktest.GetComponent<Text>().color = Color.white;
            _ilktest.text = "1. " + _playerName;
            if (_spawnScript._girlScore > _spawnEnemy._motorScore)
            {
                _ikincitext.GetComponent<Text>().color = Color.yellow;
                _ikincitext.text = "2. " + _spawnScript._yellowName;
                _ucuncutext.GetComponent<Text>().color = Color.green;
                _ucuncutext.text = "3. " + _spawnEnemy._greenName;
            }
            else
            {
                _ikincitext.GetComponent<Text>().color = Color.green;
                _ikincitext.text = "2. " + _spawnEnemy._greenName;
                _ucuncutext.GetComponent<Text>().color = Color.yellow;
                _ucuncutext.text = "3. " + _spawnScript._yellowName;
            }
        }

        if (_spawnScript._girlScore > _puan && _spawnScript._girlScore > _spawnEnemy._motorScore)
        {
            _ilktest.GetComponent<Text>().color = Color.yellow;
            _ilktest.text = "1. " + _spawnScript._yellowName;
            if (_puan > _spawnEnemy._motorScore)
            {
                _ikincitext.GetComponent<Text>().color = Color.white;
                _ikincitext.text = "2. " + _playerName;
                _ucuncutext.GetComponent<Text>().color = Color.green;
                _ucuncutext.text = "3. " + _spawnEnemy._greenName;
            }
            else
            {
                _ikincitext.GetComponent<Text>().color = Color.green;
                _ikincitext.text = "2. " + _spawnEnemy._greenName;
                _ucuncutext.GetComponent<Text>().color = Color.white;
                _ucuncutext.text = "3. " + _playerName;
            }
        }
        if (_spawnEnemy._motorScore > _puan && _spawnScript._girlScore < _spawnEnemy._motorScore)
        {
            _ilktest.GetComponent<Text>().color = Color.green;
            _ilktest.text = "1. " + _spawnEnemy._greenName;
            if (_puan > _spawnScript._girlScore)
            {
                _ikincitext.GetComponent<Text>().color = Color.white;
                _ikincitext.text = "2. " + _playerName;
                _ucuncutext.GetComponent<Text>().color = Color.yellow;
                _ucuncutext.text = "3. " + _spawnScript._yellowName;
            }
            else
            {
                _ikincitext.GetComponent<Text>().color = Color.yellow;
                _ikincitext.text = "2. " + _spawnScript._yellowName;
                _ucuncutext.GetComponent<Text>().color = Color.white;
                _ucuncutext.text = "3. " + _playerName;
            }
        }
        mesut();
        if (_kelime.Length <= _bitisSayı)
        {
            _keyborD = true;
            _walk = true;
        }
        if (_walk)
        {
            _rg.velocity = Vector3.forward * 12;
            _anim.SetFloat("hız", 0.5f);
        }
        if (_hiz >= 2 && _walk)
        {
            _rg.velocity = Vector3.forward * 13;
            _anim.SetFloat("hız", 1f);
        }
    }
    public void mesut()
    {
        foreach (var item in _kelimeTutulan)
        {
            if (_kelimeTutulan.Length <= 1)
            {
                if (_kelime[_sayı] == char.ToLower(item))
                {
                    _keybord.text = "";
                    _puan++;
                    _bitisSayı++;
                    Instantiate(_spawn, new Vector3(_kup.position.x, _kup.position.y, 1.3f * _sayı), Quaternion.identity);
                    _sayı++;
                    tutucu = item;
                    aktif = true;
                    _devamEt = true;
                    _walk = true;
                    _hiz++;
                    _audio.PlayOneShot(_skor);
                    _devamEt = false;
                }
                else
                {
                    _keybord.text = "";
                    _yanlis = true;
                    _hiz = 0;
                    _audio.PlayOneShot(_dontSkor);

                }

                _keybord = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
            }
            else
            {
                _keybord.text = "";

                _yanlis = true;
                _hiz = 0;
                _audio.PlayOneShot(_dontSkor);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "stop" && !_devamEt)
        {
            _rg.velocity = Vector3.forward * 0;
            _anim.SetFloat("hız", 0f);
            _walk = false;
        }
        if (other.gameObject.tag == "bitis" || _bitisEkranı)
        {
            _rg.velocity = Vector3.forward * 0;
            _anim.SetFloat("hız", 0f);
            _walk = false;
        }
    }


   bool TekerlikDongusu(bool _dondu)
    {
        if (_dondu)
        {
            Debug.Log("döndü doğru");
        }
        else
        {
            Debug.Log("hatalı giriş");
        }

        return _dondu;

    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textsdpawn : MonoBehaviour
{
    [SerializeField] GameObject _text;
    private Player _player;
    [SerializeField] Transform _kup;
    private int _spawnPoint=0;


 
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();


        for (int i = 0; i < _player._kelime.Length; i++)
        {

            TextMesh _yazı = _text.GetComponent<TextMesh>();
        
            _yazı.text = _player._kelime[_spawnPoint].ToString();

           
           
            Instantiate(_text, new Vector3(5.6f, 6.689f, 1.3f * _spawnPoint), Quaternion.Euler(50.56f, 270, 0));
            _spawnPoint++;
        }
    }
}

   



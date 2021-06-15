using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainscript : MonoBehaviour
{


    [SerializeField] GameObject _panel;   
    [SerializeField] GameObject _effect;





    public void Yeniden()
    {
        Time.timeScale = 1;

        _effect.SetActive(true);
        Invoke("Fear",1f);

    }

    void Fear()
    {
        SceneManager.LoadScene(1);

    }
    public void AnaMenu()
    {
        Time.timeScale = 1;
        _effect.SetActive(true);

        Invoke("AnaMenuuu",1f);
    }

    void AnaMenuuu()
    {
        SceneManager.LoadScene(0);

    }


    public void basla()
    {
        Time.timeScale = 1;
        _panel.SetActive(true);
        Invoke("ana",1);
    }
    public void cikis()
    {
        Time.timeScale = 1;
        _panel.SetActive(true);
        Invoke("quit",1);
    }

    void quit()
    {
        Application.Quit();

    }
    void ana()
    {

        SceneManager.LoadScene(1);
    }
}

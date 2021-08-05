using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class explanation : MonoBehaviour
{
    
    private GameObject sara;
    private GameObject eru;
    private GameObject exp1;
    private GameObject exp2;
    private GameObject controls;
    private GameObject ready;

    void Start()
    {
        sara = GameObject.Find("Explanation/ThisIsSara");
        eru = GameObject.Find("Explanation/TheseAreEru");
        exp1 = GameObject.Find("Explanation/Explanation");
        exp2 = GameObject.Find("Explanation/Explanation2");
        controls = GameObject.Find("Explanation/Controls");
        ready = GameObject.Find("Explanation/Ready");

        sara.transform.gameObject.SetActive(true);
        eru.transform.gameObject.SetActive(false);
        exp1.transform.gameObject.SetActive(false);
        exp2.transform.gameObject.SetActive(false);
        controls.transform.gameObject.SetActive(false);
        ready.transform.gameObject.SetActive(false);

    }

    public void TextEru()
    {
        sara.transform.gameObject.SetActive(false);
        eru.transform.gameObject.SetActive(true);
        exp1.transform.gameObject.SetActive(false);
        exp2.transform.gameObject.SetActive(false);
        controls.transform.gameObject.SetActive(false);
        ready.transform.gameObject.SetActive(false);
    }

    public void TextExp1()
    {
        sara.transform.gameObject.SetActive(false);
        eru.transform.gameObject.SetActive(false);
        exp1.transform.gameObject.SetActive(true);
        exp2.transform.gameObject.SetActive(false);
        controls.transform.gameObject.SetActive(false);
        ready.transform.gameObject.SetActive(false);          
    }

    public void TextExp2()
    {
        sara.transform.gameObject.SetActive(false);
        eru.transform.gameObject.SetActive(false);
        exp1.transform.gameObject.SetActive(false);
        exp2.transform.gameObject.SetActive(true);
        controls.transform.gameObject.SetActive(false);
        ready.transform.gameObject.SetActive(false);
    }

    public void TextControls()
    {
        sara.transform.gameObject.SetActive(false);
        eru.transform.gameObject.SetActive(false);
        exp1.transform.gameObject.SetActive(false);
        exp2.transform.gameObject.SetActive(false);
        controls.transform.gameObject.SetActive(true);
        ready.transform.gameObject.SetActive(false);
    }

    public void TextReady()
    {
        sara.transform.gameObject.SetActive(false);
        eru.transform.gameObject.SetActive(false);
        exp1.transform.gameObject.SetActive(false);
        exp2.transform.gameObject.SetActive(false);
        controls.transform.gameObject.SetActive(false);
        ready.transform.gameObject.SetActive(true);
    }

    public void RunGame()
    {
        SceneManager.LoadScene("Level1");
    }
}

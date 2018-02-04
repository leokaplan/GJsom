using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{

    public AudioClip intro;
    public GameObject title;


    void Start()
    {
        SceneManager.LoadScene(1);
    }

}
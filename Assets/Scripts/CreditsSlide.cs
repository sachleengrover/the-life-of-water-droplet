using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsSlide : MonoBehaviour
{
    [SerializeField] SlideLoader sLoader;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RewatchPres()
    {
        StartCoroutine(sLoader.LoadLevel(1));
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

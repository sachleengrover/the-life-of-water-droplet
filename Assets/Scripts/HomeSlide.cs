using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeSlide : MonoBehaviour
{
    [SerializeField] Button[] disabledButttons;
    [SerializeField] SlideLoader sLoader;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button btn in disabledButttons)
        {
            btn.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetVolume(float vol)
    {

    }

    public void StartSlides() {
        StartCoroutine(sLoader.LoadLevel(1));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidesManager : MonoBehaviour
{
    public int maxSlides = 6;
    [SerializeField] private int curentSlideIndex = 0;

    [Header("UI")]
    [SerializeField] private Button nextSlide;
    [SerializeField] private Button previousSlide;
    [SerializeField] private Button playBtn;
    [SerializeField] private Button pauseBtn;

    [System.Serializable]
    struct Slides
    {
        public string name;
        public RectTransform uI_Object;
    }

    [SerializeField] Slides[] slides;

    public static SlidesManager instance;


    void Awake()
    {
        if (instance != this)
        {
            instance = this;
        }
    }

    void Start()
    {
        slides[0].name = "Home";
        curentSlideIndex = 0;


        nextSlide.onClick.AddListener(() =>
        {
            NextSlide();
        });
        previousSlide.onClick.AddListener(() =>
        {
            PreviousSlide();
        });
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < slides.Length; i++)
        {
            if (i == curentSlideIndex)
            {

                Slides currentSlide = slides[i];
                currentSlide.uI_Object.gameObject.SetActive(true);

            }
            else
            {
                slides[i].uI_Object.gameObject.SetActive(false);
            }
        }
    }

    public void NextSlide()
    {
        if (curentSlideIndex < maxSlides)
        {
            curentSlideIndex += 1;
        }
    }

    public void PreviousSlide()
    {
        if (curentSlideIndex > 0)
        {
            curentSlideIndex -= 1;
        }
    }

    public void SetVolume(float vol)
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class SlidesScene : MonoBehaviour
{

    [SerializeField] private string _name;
    [SerializeField] private int sceneIndex;
    [SerializeField] SlideLoader sLoader;
    public VideoPlayer videoPlayer;
    [SerializeField] Button interactBtn;

    private void Awake()
    {
        
    }

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        if (videoPlayer.isPlaying)
        {
            interactBtn.gameObject.SetActive(false);
        }
        else
        {
            interactBtn.gameObject.SetActive(true);
        }
    }

    public void NextSlide()
    {
        StartCoroutine(sLoader.LoadLevel(sceneIndex += 1));
    }

    public void PreviousSlide()
    {
        StartCoroutine(sLoader.LoadLevel(sceneIndex -= 1));
    }

    public void SetVolume(float vol)
    {

    }

    public void PlayVideo()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
        else
        {
            Debug.Log("Video is already playing!");
        }
    }

    public void PauseVideo()
    {
        videoPlayer.Pause(); // Manually pause the video
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Reset the video to the first frame
        videoPlayer.Stop();
        videoPlayer.frame = 0;  // Reset to the first frame
        Debug.Log("Video finished and reset to the beginning.");
    }


}

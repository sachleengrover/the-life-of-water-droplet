using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionDuration = 1f;

    public IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionDuration);
        SceneManager.LoadScene(levelIndex);
    }
}

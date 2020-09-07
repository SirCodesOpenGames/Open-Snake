using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUtils : MonoBehaviour
{
    public GameObject fadePanel;
    public float waitTime;

    private Animator fadeAnimator;

    private void Start() {
        fadeAnimator = fadePanel.GetComponent<Animator>();
    }

    private void Play() {
        StartCoroutine(SceneTransition("SnakeGame"));
    }

    private void Quit() {
        Application.Quit();
    }

    IEnumerator SceneTransition(string scene) {
        fadeAnimator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(waitTime);
        // SceneManager.LoadScene(scene);
    }
}

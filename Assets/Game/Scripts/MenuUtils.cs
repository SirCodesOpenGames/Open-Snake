using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUtils : MonoBehaviour
{
    public float transitionTime;
    public Animator fadeAnimator;
    public string trigger;

    public void Switch(string scene) {
        SceneManager.LoadScene(scene);
    }

    public void Quit() {
        Application.Quit();
    }

    public void Open(string url) {
        Application.OpenURL(url);
    }

    public void TransitionScene(string scene) {
        StartCoroutine(SceneTransition(scene));
    }

    private IEnumerator SceneTransition(string scene) {
        fadeAnimator.SetTrigger(trigger);
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(scene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : Manager<MenuManager>
{
  public override bool DestroyOnLoad => true;

  [SerializeField] private Animator holderAnimator;

  private void Start()
  {
    Sound.PlayMenuAmbient();
    StartCoroutine(ShowAnimation());
  }

  private IEnumerator ShowAnimation()
  {
    yield return new WaitForSeconds(5);

    var trigger = Random.Range(0, 9) > 7 ? "Runs" : "Jumps";
    holderAnimator.SetTrigger(trigger);

    yield return new WaitForSeconds(30);
    StartCoroutine(ShowAnimation());
  }

  public void LoadScene(string sceneName)
  {
    Sound.PlayButtonClicked();
    SceneManager.LoadScene(sceneName);
  }
}

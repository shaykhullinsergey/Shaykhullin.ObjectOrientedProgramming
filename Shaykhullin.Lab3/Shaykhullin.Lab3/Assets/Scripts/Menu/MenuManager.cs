using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public sealed class MenuManager : Manager<MenuManager>
{
  public override bool DestroyOnLoad => true;

  public void OnGameClicked()
  {
    StartCoroutine(ChangeScene("Game"));
  }

  public void OnSettingsClicked()
  {
    StartCoroutine(ChangeScene("Settings"));
  }

  public void OnScoreClicked()
  {
    StartCoroutine(ChangeScene("Score"));
  }

  private IEnumerator ChangeScene(string sceneName)
  {
    yield return new WaitForSeconds(0.001f);
    SceneManager.LoadScene(sceneName);
  }
}

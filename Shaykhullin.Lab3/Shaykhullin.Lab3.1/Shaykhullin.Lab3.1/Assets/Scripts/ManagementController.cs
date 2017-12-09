using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagementController : MonoBehaviour
{
  [SerializeField] private GameObject settingsManagerPrefab;
  [SerializeField] private GameObject scoreManagerPrefab;
  [SerializeField] private GameObject soundManagerPrefab;

  private void Start()
  {
    Instantiate(settingsManagerPrefab);
    Instantiate(scoreManagerPrefab);
    Instantiate(soundManagerPrefab);
    SceneManager.LoadScene("Menu");
  }
}

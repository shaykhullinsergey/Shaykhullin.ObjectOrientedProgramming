using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
  public string HydrantTag => "Hydrant";

  public GameManager Game => GameManager.Instance;
  public SettingsManager Settings => SettingsManager.Instance;
  public SoundManager Sound => SoundManager.Instance;
  public ScoreManager Score => ScoreManager.Instance;
  public NotificationController Notification => FindObjectOfType<NotificationController>();

  public TInstance Instantiate<TInstance>(GameObject prefab, Transform transform)
  {
    return Instantiate(prefab, transform, false).GetComponent<TInstance>();
  }

  public TInstance Instantiate<TInstance>(GameObject prefab, Transform transform, Vector3 position)
  {
    return Instantiate(prefab, position, Quaternion.identity, transform).GetComponent<TInstance>();
  }

  public void AddSizeDelta(RectTransform transform)
  {
    transform.sizeDelta = new Vector2
    (
      transform.sizeDelta.x,
      transform.sizeDelta.y + Settings.PipeItemSizeDelta
    );
  }
  public void RemoveSizeDelta(RectTransform transform)
  {
    transform.sizeDelta = new Vector2
    (
      transform.sizeDelta.x,
      transform.sizeDelta.y - Settings.PipeItemSizeDelta
    );
  }
}
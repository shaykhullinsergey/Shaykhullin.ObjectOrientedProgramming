using UnityEngine;
using UnityEngine.UI;

public class NotificationController : PipeBehaviour
{
  [SerializeField] private Text message;
  [SerializeField] private GameObject holder;

  public void Show(string message)
  {
    this.message.text = message;
    holder.SetActive(true);
    Sound.PlayNotificationAppear();
  }

  public void OnCancel()
  {
    holder.SetActive(false);
  }
}

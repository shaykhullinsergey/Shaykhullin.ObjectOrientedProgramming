using UnityEngine;
using UnityEngine.UI;

public class PipeItem : PipeBehaviour
{
  [SerializeField] private Image holder;
  [SerializeField] private Text description;

  [SerializeField] private int minLength;
  [SerializeField] private int maxLength;
  [SerializeField] private int streamPower;

  private void Start()
  {
    minLength = Random.Range(
      Settings.MinPipeLengthMin, Settings.MinPipeLengthMax);

    maxLength = Random.Range(
      Settings.MaxPipeLengthMin, Settings.MaxPipeLengthMax);

    streamPower = Random.Range(
      Settings.MinStreamPower, Settings.MaxStreamPower);

    GetComponent<Image>().sprite = Settings.GetRandomPipeSprite();

    description.text = $"{minLength} {maxLength} {streamPower}";
  }

  private void OnMouseUp() => Game.AvaliablePipe.Select(this);

  public void Select() => holder.enabled = true;
  public void Deselect() => holder.enabled = false;
  public void Remove() => Destroy(holder.gameObject);
}
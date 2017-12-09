using UnityEngine;
using UnityEngine.UI;

public abstract class PipeItem : PipeBehaviour
{
  [SerializeField] private Image pipeItemImage;
  [SerializeField] private Text pipeItemDescription;

  [SerializeField] private int minLength;
  [SerializeField] private int maxLength;
  [SerializeField] private int streamPower;

  public int MinLength => minLength;
  public int MaxLength => maxLength;
  public int StreamPower => streamPower;
  public bool Selected { set { GetComponent<Image>().enabled = value; } }

  public abstract void Use();

  private void Start()
  {
    Sound.PlayPipeItemAppear();
    pipeItemImage.sprite = Settings.GetRandomPipeSprite();

    minLength = Random.Range(
      Settings.MinPipeLengthMin, Settings.MinPipeLengthMax);

    maxLength = Random.Range(
      Settings.MaxPipeLengthMin, Settings.MaxPipeLengthMax);

    streamPower = Random.Range(
      Settings.MinStreamPower, Settings.MaxStreamPower);

    pipeItemDescription.text = $"{minLength} {maxLength} {streamPower}";
  }

  public void OnClick() => Game.Sidebar.Select(this);
}

using UnityEngine;
using UnityEngine.UI;

public class GameResultHydrant : PipeBehaviour
{
  [SerializeField] private int id;
  [SerializeField] private Text description;
  [SerializeField] private Image hydrantImage;

  public int Id => id;

  private void Start()
  {
    hydrantImage.sprite = Settings.GetRandomHydrantSprite();
    Sound.PlayHydrantAppear();
  }

  internal void InitializeWith(HydrantResult hydrant)
  {
    id = hydrant.Id;

    description.text = hydrant.Capacity.ToString();
    description.color = hydrant.Capacity > 0
      ? Settings.PositiveHydrantColor
      : Settings.NegativeHydrantColor;
  }
}

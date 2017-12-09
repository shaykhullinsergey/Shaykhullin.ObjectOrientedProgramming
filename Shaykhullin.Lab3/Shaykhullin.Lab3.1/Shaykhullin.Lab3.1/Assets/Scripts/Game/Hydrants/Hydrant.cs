using UnityEngine;
using UnityEngine.UI;

public class Hydrant : PipeBehaviour
{
  private static int uniqueId = 0;

  [SerializeField] private int id;
  [SerializeField] private int capacity;

  [SerializeField] private Animator animator;
  [SerializeField] private Text description;
  [SerializeField] private Image hydrantSprite;

  public int Id => id;
  public int Capacity => capacity;

  private void Start()
  {
    id = uniqueId++;
    capacity = Settings.GetRandomHydrantCapacity();
    description.text = capacity.ToString();
    hydrantSprite.sprite = Settings.GetRandomHydrantSprite();

    Sound.PlayHydrantAppear();
  }

  public void ApplyConnection(Connection connection)
  {
    if(connection.From == this)
    {
      capacity -= connection.PipeRenderer.StreamPower;
    }
    else
    {
      capacity += connection.PipeRenderer.StreamPower;
    }

    animator.SetTrigger("ApplyConnection");
    SetDescription(capacity);
  }

  private void SetDescription(int capacity)
  {
    description.text = capacity.ToString();
    description.color = capacity > 0
      ? Settings.PositiveHydrantColor
      : Settings.NegativeHydrantColor;
  }

  public void OnClick()
  {
    Game.GameField.Select(this);
  }
}

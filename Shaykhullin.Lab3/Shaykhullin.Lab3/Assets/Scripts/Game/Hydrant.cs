using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Hydrant : PipeBehaviour
{
  [SerializeField] private Text description;
  [SerializeField] private int capacity;
  [SerializeField] private int power;

  [SerializeField] private bool instantiatedCorrectly = true;

  private void Start()
  {
    capacity = Random.Range(
      Settings.MinBoilerCapacity, Settings.MaxBoilerCapacity);

    power = Random.Range(
      Settings.MinFillBoilerSpeed, Settings.MaxFillBoilerSpeed);

    GetComponent<Image>().sprite = Settings.GetRandomHydrantSprite();

    description.text = $"{capacity} {power}";
  }

  public bool EnsureCreated()
  {
    if (!instantiatedCorrectly)
      Destroy(gameObject);

    return instantiatedCorrectly;
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.transform.CompareTag(HydrantTag))
    {
      instantiatedCorrectly = false;
    }
    print("Trigger");
  }

  public void MouseDown()
  {
    Game.OnMouseDown(this);
  }

  public void MouseDrag()
  {
    Game.OnMouseDrag(this);
  }

  public void MouseDrop()
  {
    Game.OnMouseUp(this);
  }

  public void OnMouseUp()
  {
    Game.OnMouseUp(this);
  }
}

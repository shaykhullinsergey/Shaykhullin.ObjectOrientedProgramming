using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public sealed class GameManager : Manager<GameManager>
{
  public override bool DestroyOnLoad => true;

  [SerializeField] private AvaliablePipeController avaliablePipe;
  public AvaliablePipeController AvaliablePipe => avaliablePipe;

  [SerializeField] private GameObject lineRenderer;
  [SerializeField] private List<LineRenderer> lineRenderers;
  [SerializeField] private GameObject hydrantPrefab;
  [SerializeField] private Transform gameField;
  [SerializeField] private List<Hydrant> hydrants;

  private IEnumerator Start()
  {
    yield return GenerateStartHydrants();
    yield return GenerateStartAvaliablePipes();
  }

  private IEnumerator GenerateStartAvaliablePipes()
  {
    for (int i = 0; i < SettingsManager.Instance.StartAvaliablePipesCount; i++)
    {
      AvaliablePipe.AddRandom();
      yield return new WaitForSeconds(0.05f);
    }
  }

  private IEnumerator GenerateStartHydrants()
  {
    var startHydrantCount = Random.Range(SettingsManager.Instance.MinStartHydrantCount, SettingsManager.Instance.MaxStartHydrantCount);

    for (int i = 0; i < startHydrantCount; i++)
    {
      yield return CreateNewHydrant();
      yield return new WaitForSeconds(0.1f);
    }
  }

  private IEnumerator CreateNewHydrant()
  {
    var hydrant = Instantiate(hydrantPrefab, gameField, false)
      .GetComponent<Hydrant>();

    hydrant.GetComponent<RectTransform>().position = SettingsManager.Instance.GenerateRandomHydrantPosition();

    yield return new WaitForSeconds(0.01f);
    if (!hydrant.EnsureCreated())
    {
      yield return CreateNewHydrant();
      yield break;
    }

    hydrants.Add(hydrant);
  }

  public void OnMouseUp(Hydrant hydrant)
  {
    lineRenderers.Last().SetPosition(1, hydrant.transform.position);
    print("UP!" + Input.mousePosition);
  }

  public void OnMouseDown(Hydrant hydrant)
  {
    var last = lineRenderers.Count > 0 ? lineRenderers.Last() : null;
    if(last == null || last.GetPosition(0) != last.GetPosition(1))
    {
      var renderer = Instantiate(lineRenderer, gameField, false).GetComponent<LineRenderer>();
      lineRenderers.Add(renderer);
    }

    last = lineRenderers.Last();

    last.SetPosition(0, hydrant.transform.position);
    last.SetPosition(1, hydrant.transform.position);

    print("DOWN!" + Input.mousePosition);
  }

  internal void OnMouseDrag(Hydrant hydrant)
  {
    var vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    lineRenderers.Last().SetPosition(1, new Vector3(vector.x, vector.y, 0));
    print("DRAG!" + Input.mousePosition);
  }
}
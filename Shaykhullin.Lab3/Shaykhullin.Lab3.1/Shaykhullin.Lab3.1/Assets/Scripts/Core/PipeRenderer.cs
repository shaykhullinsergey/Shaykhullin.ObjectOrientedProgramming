using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PipeRenderer : PipeBehaviour
{
  public GameObject StreamPowerUi => streamPowerUi;
  public int StreamPower => streamPower;

  [SerializeField] private LineRenderer lineRenderer;
  [SerializeField] private GameObject streamPowerPrefab;
  [SerializeField] private GameObject streamPowerUi;
  [SerializeField] private int streamPower;

  public PipeRenderer WithStartPosition(Vector3 startPosition)
  {
    lineRenderer.SetPosition(0, startPosition);
    lineRenderer.SetPosition(1, startPosition);
    lineRenderer.SetPosition(2, startPosition);
    lineRenderer.SetPosition(3, startPosition);
    lineRenderer.SetPosition(4, startPosition);
    Sound.PlayPipeRendererStart();
    return this;
  }

  public PipeRenderer WithEndPosition(Vector3 endPosition)
  {
    var origin = lineRenderer.GetPosition(0);

    lineRenderer.SetPosition(1, Vector3.Lerp(origin, endPosition, 0.6f));
    lineRenderer.SetPosition(2, Vector3.Lerp(origin, endPosition, 0.61f));
    lineRenderer.SetPosition(3, Vector3.Lerp(origin, endPosition, 0.707f));
    lineRenderer.SetPosition(4, endPosition);
    return this;
  }
  
  public PipeRenderer WithStreamPower(int streamPower)
  {
    var origin = lineRenderer.GetPosition(0);
    var target = lineRenderer.GetPosition(4);
    streamPowerUi = Instantiate
    (
      streamPowerPrefab, 
      new Vector3((origin.x + target.x) / 2, (origin.y + target.y) / 2, -1),
      Quaternion.identity, 
      transform
    );
    streamPowerUi.GetComponentInChildren<Text>().text = streamPower.ToString();

    this.streamPower = streamPower;
    Sound.PlayPipeRendererEnd();
    return this;
  }

  public PipeRenderer WithColor(Color lineColor)
  {
    lineRenderer.startColor = lineRenderer.endColor = lineColor;
    return this;
  }

  public void ApplyEndTurn() => StartCoroutine(ApplyEndTurnCoroutine());

  private IEnumerator ApplyEndTurnCoroutine()
  {
    Sound.PlayHydrantEndTurn();

    WithColor(Settings.PipeActivatedColor);
    streamPowerUi.transform.localScale = new Vector3(
      streamPowerUi.transform.localScale.x + 0.1f,
      streamPowerUi.transform.localScale.y + 0.1f,
      streamPowerUi.transform.localScale.z);

    yield return new WaitForSeconds(0.4f);

    WithColor(SettingsManager.Instance.PipeConnectedColor);
    streamPowerUi.transform.localScale = new Vector3(
      streamPowerUi.transform.localScale.x - 0.1f,
      streamPowerUi.transform.localScale.y - 0.1f,
      streamPowerUi.transform.localScale.z);
  }
}

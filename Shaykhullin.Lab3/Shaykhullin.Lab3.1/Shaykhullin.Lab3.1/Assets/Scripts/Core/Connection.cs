using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class Connection
{
  public Hydrant To => to;
  public Hydrant From => from;
  public PipeRenderer PipeRenderer => pipeRenderer;

  [SerializeField] private Hydrant to;
  [SerializeField] private Hydrant from;
  [SerializeField] private PipeRenderer pipeRenderer;

  public Connection(Hydrant from, PipeRenderer pipeRenderer, Hydrant to)
  {
    this.from = from;
    this.pipeRenderer = pipeRenderer;
    this.to = to;
  }

  public void ApplyEndTurn() => pipeRenderer.ApplyEndTurn();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvaliablePipeController : PipeBehaviour
{
  [Header("AvaliablePipe")]
  [SerializeField] private GameObject content;
  [SerializeField] private GameObject pipePrefab;
  
  [Header("PipeItems")]
  [SerializeField] private PipeItem selected;
  [SerializeField] private List<PipeItem> items;

  public PipeItem Selected => selected;

  public void AddRandom()
  {
    var pipeItem = Instantiate(pipePrefab, content.transform, false)
      .GetComponentInChildren<PipeItem>();

    var sizeDelta = pipeItem.GetComponent<RectTransform>().sizeDelta.y + Settings.ShiftForAvaliablePipeUI;
    var contentRect = content.GetComponent<RectTransform>();
    contentRect.sizeDelta = new Vector2(contentRect.sizeDelta.x, contentRect.sizeDelta.y + sizeDelta);
    
    items.Add(pipeItem);
  }
  
  public void Select(PipeItem item)
  {
    if(selected == item)
    {
      return;
    }
    
    selected?.Deselect();
    item.Select();
    
    selected = item;
  }

  public void RemoveSelected()
  {
    if(selected == null)
    {
      print("Selected is null");
      return;
    }

    var sizeDelta = selected.GetComponent<RectTransform>().sizeDelta.y + Settings.ShiftForAvaliablePipeUI;
    var contentRect = content.GetComponent<RectTransform>();
    contentRect.sizeDelta = new Vector2(contentRect.sizeDelta.x, contentRect.sizeDelta.y - sizeDelta);

    items.Remove(selected);
    selected.Remove();
    selected = null;
  }
}

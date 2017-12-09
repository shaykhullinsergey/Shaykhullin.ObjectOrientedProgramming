using UnityEngine;

public abstract class Manager<TManager> : MonoBehaviour where TManager : Manager<TManager>
{
  public static TManager Instance { get; private set; }

  public abstract bool DestroyOnLoad { get; }

  private void Awake()
  {
    if(Instance == null)
    {
      Instance = (TManager)this;
      if(!DestroyOnLoad)
      {
        DontDestroyOnLoad(gameObject);
      }
    }
    else
    {
      Destroy(gameObject);
    }
  }

  private void OnDestroy()
  {
    if(DestroyOnLoad)
    {
      Instance = null;
    }
  }
}
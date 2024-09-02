using Buck.SaveAsync;
using UnityEngine;

public class WorldPositionSaver : MonoBehaviour, ISaveable
{
    Vector3 m_savedState;
    string m_cachedName;
    public string Key => m_cachedName + "_position";
    public string Filename => m_filename;
    [SerializeField] string m_filename = "level.dat";
    public object CaptureState()
    {
        var savedData = m_savedState;
        Debug.Log($"Saving world position for {m_cachedName}, saving {savedData} ");
        return savedData;
    }

    public void RestoreState(object state)
    {
        Debug.Log($"Loading world position for {m_cachedName}, loaded {state}");
        var typedState = (Vector3)state;
        m_savedState = typedState;
        transform.position = typedState;
    }

    void Awake()
    {
        m_cachedName = name;
        SaveManager.RegisterSaveable(this);
    }

    void FixedUpdate()
    {
        m_savedState = transform.position;
    }
}

using Buck.SaveAsync;
using UnityEngine;

public class SaveManagerUnityInvokeable : MonoBehaviour
{
    public async void TriggerSave(string filename)
    {
        await SaveManager.Save(filename);
    }
    
    public async void TriggerLoad(string filename)
    {
        await SaveManager.Load(filename);
    }
    
    public async void TriggerDelete(string filename)
    {
        await SaveManager.Delete(filename);
    }
    
    public async void TriggerErase(string filename)
    {
        await SaveManager.Erase(filename);
    }
}
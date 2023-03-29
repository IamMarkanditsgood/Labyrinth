using System.Collections.Generic;
using UnityEngine;

public class PoolObjectCreator
{
    public void CreateObjectForPool(GameObject prefab, List<GameObject> poolObject)
    {
        GameObject obj = Object.Instantiate(prefab);
        obj.SetActive(false);
        poolObject.Add(obj);
        ConnectToContainer(obj);
    }
    private void ConnectToContainer(GameObject obj)
    {
        obj.transform.SetParent(DataScripts.LevelData.instance.AmmunitionContainer);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour
{
    public Dictionary<ResourcesTypeSO,int> ResourceAmountDictionary;

    private void Awake()
    {
        ResourceAmountDictionary = new Dictionary<ResourcesTypeSO, int>();

        ResourcesTypeListSO resourcesTypeList = Resources.Load<ResourcesTypeListSO>(typeof(ResourcesTypeListSO).Name);

        foreach (ResourcesTypeSO resourcesType in resourcesTypeList.List)
        {
            ResourceAmountDictionary[resourcesType] = 0;
        }
    }
}

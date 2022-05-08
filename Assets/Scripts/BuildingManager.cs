using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    [SerializeField]private Transform mouseSprite;
    [SerializeField]private BuildingTypeSO buildingType; 
    private Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Resources.Load<BuildingTypeListSO>("BuildingTypeListSO"));
        MainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(buildingType.prefab, mousePos(),this.transform.rotation);
        }
        mouseSprite.position = mousePos();
    }
    private Vector3 mousePos()
    {
        Vector3 mousePos = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}

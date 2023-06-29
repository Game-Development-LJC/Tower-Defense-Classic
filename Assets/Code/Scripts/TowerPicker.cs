using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPicker : MonoBehaviour
{
    public GameObject tower;
    public GameObject towerPicker;
    
    void OnMouseDown()
    {
        tower.SetActive(true);
        towerPicker.SetActive(false);
    }
    
}

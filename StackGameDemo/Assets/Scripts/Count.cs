using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Count : MonoBehaviour
{
    public GameObject TowerPrefab;
    public TextMeshPro textTower;
    public TextMeshPro textArcher;

    private void DestroyObjects ()
    {
        GameObject[] resources = GameObject.FindGameObjectsWithTag("Wood");
        for (int i = 0; i < resources.Length; i++)
        {
            Destroy(resources[i]);
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        DestroyObjects();
        
        if (WoodToplayici.count >= 20)
        {
            CountWoodUI.textWoodCount.SetText("20/20 \nWoods");
        }
        else
        {
            CountWoodUI.textWoodCount.SetText(WoodToplayici.count.ToString() + "/20" +  " \nWood");
        }
    }
}

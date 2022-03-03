using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountGold : MonoBehaviour
{
    public GameObject TowerPrefab;
    public TextMeshPro textTower;
    public TextMeshPro textArcher;
    private void DestroyObjects()
    {
        GameObject[] resources = GameObject.FindGameObjectsWithTag("Gold");
        for (int i = 0; i < resources.Length; i++)
        {
            Destroy(resources[i]);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        DestroyObjects();

        if (GoldToplayici.count >= 20)
        {
            CountGoldUI.textGoldCount.SetText("20/20 \nGold");
        }
        else
        {
            CountGoldUI.textGoldCount.SetText(GoldToplayici.count.ToString() + "/20" + " \nGold");
        }
    }
}

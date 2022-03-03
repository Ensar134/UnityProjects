using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountStone : MonoBehaviour
{
    public GameObject TowerPrefab;
    public GameObject ArcherPrefab;
    public GameObject SoldierPrefab;
    public TextMeshPro textTower;
    public TextMeshPro textArcher;
    public TextMeshPro textSecondArcher;
    public TextMeshPro textThirdArcher;
    public TextMeshPro textTower2;
    public TextMeshPro textSpearSoldier;
    public TextMeshPro textSpearSoldier2;
    public TextMeshPro textSpearSoldier3;
    private int stageCount = 0;

    private void Start()
    {
        textArcher.enabled = false;
    }

    private void CreateTower()
    {
        if (stageCount == 0)
        {
            if (WoodToplayici.count >= 20 && StoneToplayici.count >= 20 && GoldToplayici.count >= 20)
            {
                Vector3 pos = new Vector3(8.25f, 2.5f, 19.5f);
                Instantiate(TowerPrefab, pos, Quaternion.identity);
                textTower.enabled = false;
                textArcher.enabled = true;
                ReturnZero();
                stageCount += 1;
            }
        }
        if (stageCount == 1)
        {
            if (StoneToplayici.count >= 20 && GoldToplayici.count >= 20)
            {
                Vector3 pos2 = new Vector3(7.5f, 5f, 19f);
                Instantiate(ArcherPrefab, pos2, Quaternion.Euler(0, 180, 0));
                textArcher.enabled = false;
                textSecondArcher.enabled = true;
                ReturnZero();
                stageCount += 1;
            }
        }
        if (stageCount == 2)
        {
            if (StoneToplayici.count >= 20 && GoldToplayici.count >= 20)
            {
                Vector3 pos3 = new Vector3(8.5f, 5f, 19f);
                Instantiate(ArcherPrefab, pos3, Quaternion.Euler(0, 180, 0));
                textSecondArcher.enabled = false;
                textThirdArcher.enabled = true;
                ReturnZero();
                stageCount += 1;
            }

        }
        if (stageCount == 3)
        {
            if (StoneToplayici.count >= 20 && GoldToplayici.count >= 20)
            {
                Vector3 pos4 = new Vector3(8f, 5f, 18f);
                Instantiate(ArcherPrefab, pos4, Quaternion.Euler(0, 180, 0));
                textThirdArcher.enabled = false;
                textTower2.enabled = true;
                ReturnZero();
                stageCount += 1;
            }
        }
        if(stageCount == 4)
        {
            if (WoodToplayici.count >= 20 && StoneToplayici.count >= 20)
            {
                Vector3 pos = new Vector3(2.25f, 2.5f, 19.5f);
                Instantiate(TowerPrefab, pos, Quaternion.identity);
                textTower2.enabled = false;
                textSpearSoldier.enabled = true;
                ReturnZero();
                stageCount += 1;
            }
        }
        if (stageCount == 5)
        {
            if (WoodToplayici.count >= 20 && StoneToplayici.count >= 20)
            {
                Vector3 pos = new Vector3(1.25f, 5f, 20f);
                Instantiate(SoldierPrefab, pos, Quaternion.Euler(0, 180, 0));
                textSpearSoldier.enabled = false;
                textSpearSoldier2.enabled = true;
                ReturnZero();
                stageCount += 1;
            }
        }
        if (stageCount == 6)
        {
            if (WoodToplayici.count >= 20 && StoneToplayici.count >= 20)
            {
                Vector3 pos = new Vector3(2.75f, 5f, 20f);
                Instantiate(SoldierPrefab, pos, Quaternion.Euler(0, 180, 0));
                textSpearSoldier2.enabled = false;
                textSpearSoldier3.enabled = true;
                ReturnZero();
                stageCount += 1;
            }
        }
        if (stageCount == 7)
        {
            if (WoodToplayici.count >= 20 && StoneToplayici.count >= 20)
            {
                Vector3 pos = new Vector3(2.25f, 5f, 19f);
                Instantiate(SoldierPrefab, pos, Quaternion.Euler(0, 180, 0));
                textSpearSoldier3.enabled = false;
                ReturnZero();
                stageCount += 1;
            }
        }
        if (stageCount == 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void ReturnZero()
    {
        WoodToplayici.count = 0;
        CountWoodUI.textWoodCount.SetText("0/20 \nWood");
        GoldToplayici.count = 0;
        CountGoldUI.textGoldCount.SetText("0/20 \nGold");
        StoneToplayici.count = 0;
        CountStoneUI.textStoneCount.SetText("0/20 \nStone");
    }
    private void DestroyObjects()
    {
        GameObject[] resources = GameObject.FindGameObjectsWithTag("Stone");
        for (int i = 0; i < resources.Length; i++)
        {
            Destroy(resources[i]);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        DestroyObjects();
        
        if (StoneToplayici.count >= 20)
        {
            CountStoneUI.textStoneCount.SetText("20/20 \nStone");
            CreateTower();
        }
        else
        {
            CountStoneUI.textStoneCount.SetText(StoneToplayici.count.ToString() + "/20" + " \nStone");
        }
    }
}

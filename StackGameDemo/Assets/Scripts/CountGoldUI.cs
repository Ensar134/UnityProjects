using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountGoldUI : MonoBehaviour
{
    public static TextMeshPro textGoldCount;

    void Start()
    {
        textGoldCount = GetComponent<TextMeshPro>();
    }

    void Update()
    {

    }
}

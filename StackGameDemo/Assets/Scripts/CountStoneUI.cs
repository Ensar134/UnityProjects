using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountStoneUI : MonoBehaviour
{
    public static TextMeshPro textStoneCount;

    void Start()
    {
        textStoneCount = GetComponent<TextMeshPro>();
    }

    void Update()
    {

    }
}

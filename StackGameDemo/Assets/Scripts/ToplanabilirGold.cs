using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirGold : MonoBehaviour
{
    bool toplandiMi;
    int index;

    void Start()
    {
        toplandiMi = false;
    }


    private void Update()
    {
        if (toplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, +index, 0);
            }
        }
    }
    public bool GetToplandiMi()
    {
        return toplandiMi;
    }
    public void ToplandiYap()
    {
        toplandiMi = true;
    }
    public void HeightSettings(int index)
    {
        this.index = index;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EngelGold")
        {
            GoldToplayici.yukseklikgold = 0;
            transform.parent = null;
        }
    }
}

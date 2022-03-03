using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldToplayici : MonoBehaviour
{
    GameObject bag;
    public static int yukseklikgold;
    public static int count = 0;

    void Start()
    {
        bag = GameObject.Find("Bag");
    }
    void Update()
    {
        bag.transform.position = new Vector3(transform.position.x, yukseklikgold + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklikgold, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gold"))
        {
            count += 1;
            //yukseklikgold += 1;
            other.gameObject.GetComponent<ToplanabilirGold>().ToplandiYap();
            other.gameObject.GetComponent<ToplanabilirGold>().HeightSettings(yukseklikgold);
            other.gameObject.transform.parent = bag.transform;
        }
    }
}

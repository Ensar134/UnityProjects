using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneToplayici : MonoBehaviour
{
    GameObject bag;
    public static int yukseklikstone;
    public static int count = 0;

    void Start()
    {
        bag = GameObject.Find("Bag");
    }
    void Update()
    {
        bag.transform.position = new Vector3(transform.position.x, yukseklikstone + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklikstone , 0);       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stone")) 
        {
            count += 1;
            yukseklikstone = 0;
            other.gameObject.GetComponent<ToplanabilirStone>().ToplandiYap();
            other.gameObject.GetComponent<ToplanabilirStone>().HeightSettings(yukseklikstone);
            other.gameObject.transform.parent = bag.transform;
        }
    }
}

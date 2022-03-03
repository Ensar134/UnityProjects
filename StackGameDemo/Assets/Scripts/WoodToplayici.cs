using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodToplayici : MonoBehaviour
{
    GameObject bag;
    public static int yukseklikwood;
    public static int count = 0;
           
    void Start()
    {
        bag = GameObject.Find("Bag");   
    }

    void Update()
    {
        bag.transform.position = new Vector3(transform.position.x, yukseklikwood + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklikwood , 0);       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            count += 1;
            //yukseklikwood += 1;
            other.gameObject.GetComponent<ToplanabilirWood>().ToplandiYap();
            other.gameObject.GetComponent<ToplanabilirWood>().HeightSettings(yukseklikwood);
            other.gameObject.transform.parent = bag.transform;
        }
    }
}

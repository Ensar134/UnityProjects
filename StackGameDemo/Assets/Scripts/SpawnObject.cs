using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public GameObject Woodprefab;
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        while (true)
        {
            yield return new WaitForSeconds((float)0.2);
            SpawnResource();
        }
               
    }
    void Update()
    {
        
    }

    public void SpawnResource ()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(Woodprefab, pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color= new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size); 
    }

}

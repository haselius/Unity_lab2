using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conrtol : MonoBehaviour
{
    public GameObject platform;
   // public int AmountofPlatforms = 30;
    // Start is called before the first frame update
    IEnumerator Spawn()
    {
        Vector3 SpawnPos = new Vector3();
        while(true)
        {
            SpawnPos.y += Random.Range(.5f,1f);
            SpawnPos.x = Random.Range(-10, 10);
            Instantiate(platform,SpawnPos,Quaternion.identity);
            yield return new WaitForSeconds(.5f);
        }
    }

    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManger : MonoBehaviour
{
  
    public float range = 10;
    public GameObject enemyprefab;
    [SerializeField] int vawerate=3;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Genraterandpostion", 12 , 1.5f );
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public Vector3 Genraterandpostion()
    {
        float spawnx = Random.Range(-range,range);
        float spawnz = Random.Range(-range,range);
        Vector3 randompos = new Vector3(spawnx,0.5f,spawnz);
        Instantiate(enemyprefab,randompos, enemyprefab.transform.rotation);
        return randompos;
    }
}

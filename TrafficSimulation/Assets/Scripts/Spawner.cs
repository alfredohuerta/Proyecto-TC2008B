using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float time = 300f;
    public float movementSpeed = 100f;
    public GameObject[] vehicle;
    public Transform[] spawnpoint;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVehicle",0f,10f);
        Time.timeScale=10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnVehicle()
    {
        int x = Random.Range(0,3);
        GameObject spawn;
        switch(x)
        {
            case 0:
                spawn = Instantiate(vehicle[0],spawnpoint[0].position,Quaternion.identity);
                spawn.SetActive(true);
                spawn.GetComponent<Rigidbody>().AddForce(new Vector3(0f,0f,movementSpeed));
                Destroy(spawn,time);
                break;
            case 1:
                spawn = Instantiate(vehicle[1],spawnpoint[1].position,Quaternion.identity);
                spawn.SetActive(true);
                spawn.GetComponent<Rigidbody>().AddForce(new Vector3(0f,0f,movementSpeed));
                Destroy(spawn,time);
                break;
            case 2:
                spawn = Instantiate(vehicle[2],spawnpoint[2].position,Quaternion.identity);
                spawn.SetActive(true);
                spawn.GetComponent<Rigidbody>().AddForce(new Vector3(0f,0f,movementSpeed));
                Destroy(spawn,time);
                break;
        }        
    }
}
